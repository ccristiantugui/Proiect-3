using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorMedia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMedia;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;

namespace RazorMedia.Pages.Media
{
    public class ShowModel : PageModel
    {
        MediaManagerClient mmc = new MediaManagerClient();
        public List<MediaDTO> Media { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList People { get; set; }
        public SelectList CustomAttributes { get; set; }
        public SelectList MediaType { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MediaPeople { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MediaCustomAttributes { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MediaSearch { get; set; }

        [BindProperty(SupportsGet = true)]
        public String MediaMediaType { get; set; }

        [BindProperty(SupportsGet = true)]
        public int ResultsNumber { get; set; }

        public ShowModel()
        {
            Media = new List<MediaDTO>();
        }

        public async Task OnGetAsync()
        {
            List<ServiceReferenceMedia.Media> media = new List<ServiceReferenceMedia.Media>();

            var people = await mmc.GetAllPersonsAsync();
            People = new SelectList(people);

            var customAttributes = await mmc.GetAllAttributesAsync();
            CustomAttributes = new SelectList(customAttributes);

            List<String> mediaTypeList = new List<String>();
            mediaTypeList.Add("Photo");
            mediaTypeList.Add("Video");
            MediaType = new SelectList(mediaTypeList);

            if (string.IsNullOrEmpty(SearchString))
            {
                media = await mmc.SearchInDBAsync("");
            }
            else
            {
                media = await mmc.SearchInDBAsync(SearchString);
            }

            if (!string.IsNullOrEmpty(MediaPeople))
            {
                List<ServiceReferenceMedia.Media> auxMedia = new List<ServiceReferenceMedia.Media>();

                foreach (var item in media)
                {
                    foreach (var p in item.People)
                    {
                        if (p.Name == MediaPeople)
                        {
                            auxMedia.Add(item);
                            break;
                        }
                    }
                }
                media = auxMedia;
            }

            if (!string.IsNullOrEmpty(MediaCustomAttributes))
            {
                List<ServiceReferenceMedia.Media> auxMedia = new List<ServiceReferenceMedia.Media>();

                foreach (var item in media)
                {
                    foreach (var p in item.CustomAttributes)
                    {
                        if (p.Description == MediaCustomAttributes)
                        {
                            auxMedia.Add(item);
                            break;
                        }
                    }
                }
                media = auxMedia;
            }

            if (!string.IsNullOrEmpty(MediaMediaType))
            {
                List<ServiceReferenceMedia.Media> auxMedia = new List<ServiceReferenceMedia.Media>();

                foreach (var item in media)
                {
                    if (item.MediaType.ToString() == MediaMediaType)
                    {
                        auxMedia.Add(item);
                    }
                }
                media = auxMedia;
            }

          
            ResultsNumber = media.Count;

            foreach (var item in media)
            {

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<ServiceReferenceMedia.Media, RazorMedia.Models.MediaDTO>();
                    cfg.CreateMap<ServiceReferenceMedia.Location, RazorMedia.Models.LocationDTO>();
                    cfg.CreateMap<ServiceReferenceMedia.Event, RazorMedia.Models.EventDTO>();
                    cfg.CreateMap<ServiceReferenceMedia.Person, RazorMedia.Models.PersonDTO>();
                    cfg.CreateMap<ServiceReferenceMedia.CustomAttributes, RazorMedia.Models.CustomAttributesDTO>();

                });

                IMapper mapper = config.CreateMapper();

                MediaDTO md = new MediaDTO();
                md = mapper.Map<ServiceReferenceMedia.Media, RazorMedia.Models.MediaDTO>(item);


                Media.Add(md);

                String fileName = System.IO.Path.GetFileName(md.Path);
                String destPath = "./wwwroot/MediaStorage/";
                destPath = destPath + fileName;
                try
                {
                    System.IO.File.Copy(md.Path, destPath);
                }
                catch (Exception e)
                {
                }
            }

            Media.OrderBy(x => x.Path);
        }
    }
}
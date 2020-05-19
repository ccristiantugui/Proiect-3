using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF;

namespace ObjectWCF
{
    public class MediaManager : IMediaManager
    {
        public Media GetMedia(string path)
        {
            return API.getMediaByPath(path);
        }

        public bool AddCustomAttribute(CustomAttributes customAttribute)
        {
            return API.addCustomAttributeToDatabase(customAttribute);
        }

        public bool AddEvent(Event mediaEvent)
        {
            return API.addEventToDatabase(mediaEvent);
        }

        public bool AddLocation(Location location)
        {
            return API.addLocationToDatabase(location);
        }

        public bool AddMedia(Media media, List<Person> people, List<CustomAttributes> customAttributes)
        {
            return API.addMediaToDatabase(media, people, customAttributes);
        }

        public bool AddPerson(Person person)
        {
            return API.addPersonToDatabase(person);
        }

        public int DeleteMedia(Media media)
        {
            return API.removeMediaFromDatabase(media);
        }

        public List<string> GetAllAttributes()
        {
            return API.getCustomAttributesFromDB();
        }

        public List<string> GetAllPersons()
        {
            return API.getPersonsFromDB();    
        }

        public CustomAttributes GetAttributeByDescription(string description)
        {
            return API.getAttributeByDescription(description);
        }

        public Event GetEventByName(string name)
        {
            return API.getEventByName(name);
        }

        public Location GetLocationByName(string name)
        {
            return API.getLocationByName(name);
        }

        public Person GetPersonByName(string name)
        {
            return API.getPersonByName(name);
        }

        public List<Media> SearchInDB(string searchKey)
        {
            return API.searchInDB(searchKey);
        }

        public bool UpdateMedia(Media oldMedia, Media newMedia, List<Person> people, List<CustomAttributes> customAttributes)
        {
            return API.updateMediaInDatabase(oldMedia, newMedia, people, customAttributes);
        }
    }
}

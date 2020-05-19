using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.Entity.Migrations;

namespace WCF
{
    public static class API
    {
        public static bool addMediaToDatabase(Media media, List<Person> people, List<CustomAttributes> customAttributes)
        {
            /// Adauga in baza de date o intrare cu valorile parametrilor. 
            /// Daca calea specificata se afla in baza de date, atunci datele vor fi modificate cu noii parametrii.
            /// Returneaza True pentru executie reusita sau False altfel.

            using (MediaContainer ctx = new MediaContainer())
            {
                Media searchedMedia = ctx.Media
                                         .Where(m => m.Path == media.Path)
                                         .FirstOrDefault();
                if (searchedMedia == null)
                {
                    try
                    {
                        var it = ctx.Entry<Media>(media).State = EntityState.Added;

                        Console.WriteLine(media.LocationLocationID);

                        foreach (Person p in people)
                        {
                            if (media.People == null)
                            {
                                media.People = new List<Person>();
                            }
                            if (!media.People.Contains(p))
                            {
                                ctx.Entry<Person>(p).State = EntityState.Unchanged;
                                media.People.Add(p);
                            }
                        }

                        foreach (CustomAttributes custom in customAttributes)
                        {
                            if (custom.Description.Any())
                            {
                                if (media.CustomAttributes == null)
                                {
                                    media.CustomAttributes = new List<CustomAttributes>();
                                }
                                if (!media.CustomAttributes.Contains(custom))
                                {
                                    ctx.Entry<CustomAttributes>(custom).State = EntityState.Unchanged;
                                    media.CustomAttributes.Add(custom);
                                }
                            }
                        }

                        Location location = ctx.Locations.Find(media.LocationLocationID);
                        ctx.Entry<Location>(location).State = EntityState.Unchanged;

                        Event mEvent = ctx.Events.Find(media.EventEventID);
                        ctx.Entry<Event>(mEvent).State = EntityState.Unchanged;

                        ctx.SaveChanges();
                    }
                    catch (DbEntityValidationException e)
                    {
                        foreach (var eve in e.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                        throw;
                    }
                    return true;
                }
                else
                {
                    return updateMediaInDatabase(searchedMedia, media, people, customAttributes);
                }
            }
        }

        public static bool updateMediaInDatabase(Media oldMedia, Media newMedia, List<Person> people, List<CustomAttributes> customAttributes)
        {
            using (MediaContainer ctx = new MediaContainer())
            {
                //Media oldMedia = ctx.Media.Find(media.MediaID);

                oldMedia = ctx.Media.Include(m => m.CustomAttributes).Include(m => m.People).Where(m => m.MediaID == oldMedia.MediaID).First();

                if (oldMedia == null)
                {
                    return false;
                }
                else
                {
                    foreach (Person person in oldMedia.People.ToList())
                    {
                        oldMedia.People.Remove(person);
                    }

                    foreach (CustomAttributes custom in oldMedia.CustomAttributes.ToList())
                    {
                        oldMedia.CustomAttributes.Remove(custom);
                    }

                    oldMedia.Path = newMedia.Path;
                    oldMedia.MediaType = newMedia.MediaType;
                    oldMedia.ModifiedAt = newMedia.ModifiedAt;
                    oldMedia.Location = newMedia.Location;
                    oldMedia.LocationLocationID = newMedia.LocationLocationID;
                    Location location = ctx.Locations.Find(oldMedia.LocationLocationID);
                    ctx.Entry<Location>(location).State = EntityState.Unchanged;

                    oldMedia.Event = newMedia.Event;
                    oldMedia.EventEventID = newMedia.EventEventID;
                    Event mEvent = ctx.Events.Find(oldMedia.EventEventID);
                    ctx.Entry<Event>(mEvent).State = EntityState.Unchanged;

                    foreach (Person p in people)
                    {
                        Person auxPerson = ctx.People.Find(p.PersonID);
                        if (oldMedia.People == null)
                        {
                            oldMedia.People = new List<Person>();
                        }
                        if (!oldMedia.People.Contains(auxPerson))
                        {
                            //ctx.Set<Person>().AddOrUpdate(auxPerson);
                            ctx.Entry<Person>(auxPerson).State = EntityState.Unchanged;

                            oldMedia.People.Add(auxPerson);
                        }
                    }

                    foreach (CustomAttributes custom in customAttributes)
                    {
                        if (custom.Description.Any())
                        {
                            CustomAttributes auxAttribute = ctx.CustomAttributes.Find(custom.CustomAttributeID);
                            if (oldMedia.CustomAttributes == null)
                            {
                                oldMedia.CustomAttributes = new List<CustomAttributes>();
                            }
                            if (!oldMedia.CustomAttributes.Contains(auxAttribute))
                            {
                                //ctx.Set<CustomAttributes>().AddOrUpdate(auxAttribute);
                                ctx.Entry<CustomAttributes>(auxAttribute).State = EntityState.Unchanged;
                                oldMedia.CustomAttributes.Add(auxAttribute);
                            }
                        }
                    }
                    ctx.SaveChanges();
                    return true;
                }
            }
        }

        public static int removeMediaFromDatabase(Media media)
        {
            /// Sterge din baza de date intrarea cu calea specificata in parametrii.
            /// Returneaza True pentru executie reusita sau False altfel.

            using (MediaContainer ctx = new MediaContainer())
            {
                try
                {
                    ctx.Media.Attach(media);
                    ctx.Entry<Media>(media).State = EntityState.Deleted;
                    ctx.SaveChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    return 0;
                }
            }
        }

        public static Media getMediaByPath(string path)
        {
            using (MediaContainer ctx = new MediaContainer())
            {
                //var media = from m in ctx.Media where m.Path == path select m;
                var media = ctx.Media
                               .Where(m => m.Path == path)
                               .SingleOrDefault();
                return media;
            }
        }

        public static bool addLocationToDatabase(Location location)
        {
            using (MediaContainer ctx = new MediaContainer())
            {
                if (location.LocationID == 0)
                {
                    var it = ctx.Entry<Location>(location).State = EntityState.Added;
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static Location getLocationByName(string name)
        {
            using (MediaContainer ctx = new MediaContainer())
            {
                var location = ctx.Locations
                                   .Where(l => l.Name == name)
                                   .FirstOrDefault();

                if (location != null)
                {
                    Console.WriteLine(location.Name);
                }
                return location;
            }
        }

        public static bool addEventToDatabase(Event mediaEvent)
        {
            using (MediaContainer ctx = new MediaContainer())
            {
                if (mediaEvent.EventID == 0)
                {
                    var it = ctx.Entry<Event>(mediaEvent).State = EntityState.Added;
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static Event getEventByName(string name)
        {
            using (MediaContainer ctx = new MediaContainer())
            {
                var mediaEvent = ctx.Events
                                    .Where(e => e.Name == name)
                                    .FirstOrDefault();

                return mediaEvent;
            }
        }

        public static bool addPersonToDatabase(Person person)
        {
            using (MediaContainer ctx = new MediaContainer())
            {
                if (person.PersonID == 0)
                {
                    ctx.People.Add(person);
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static List<string> getPersonsFromDB()
        {
            /// Returneaza lista de persoane existente in baza de date.

            using (MediaContainer ctx = new MediaContainer())
            {
                List<string> persons = new List<string>();
                var personsResults = (from p in ctx.People select p.Name);
                if (personsResults.Any())
                    persons = personsResults.ToList();
                return persons;
            }
        }
        public static Person getPersonByName(string name)
        {
            using (MediaContainer ctx = new MediaContainer())
            {
                //Person person = ctx.People
                //                .FirstOrDefault(p => p.Name == name);

                var result = from p in ctx.People where p.Name == name select p;

                if (result.Any())
                {
                    return result.First();
                }
                return null;
            }
        }

        public static bool addCustomAttributeToDatabase(CustomAttributes customAttributes)
        {
            using (MediaContainer ctx = new MediaContainer())
            {
                if (customAttributes.CustomAttributeID == 0)
                {
                    ctx.CustomAttributes.Add(customAttributes);
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static List<string> getCustomAttributesFromDB()
        {
            /// Returneaza lista de atribute "custom" existente in baza de date.

            using (MediaContainer ctx = new MediaContainer())
            {
                List<string> attributes = new List<string>();
                var attributesResults = (from ca in ctx.CustomAttributes select ca.Description);
                if (attributesResults.Any())
                    attributes = attributesResults.ToList();
                return attributes;
            }
        }

        public static CustomAttributes getAttributeByDescription(string description)
        {
            using (MediaContainer ctx = new MediaContainer())
            {
                var attribute = ctx.CustomAttributes
                                    .Where(a => a.Description == description)
                                    .FirstOrDefault();
                return attribute;
            }
        }

        public static List<Media> searchInDB(string searchQuery)
        {
            /// Primeste un string ce contine cuvinte cheie.
            /// Returneaza o lista de obiecte de tip Media ce se potrivesc cautarii.

            using (MediaContainer ctx = new MediaContainer())
            {
                searchQuery = searchQuery.ToLower();

                List<Media> foundMedia = new List<Media>();

                var media = ctx.Media.Include(m => m.Location)
                                 .Include(m => m.Event)
                                 .Include(m => m.People)
                                 .Include(m => m.CustomAttributes)
                                 .Where(m => m.Path.ToLower().Contains(searchQuery) || searchQuery.Contains(m.Path.ToLower()));

                addSearchResultToList(foundMedia, media);

                media = ctx.Media.Include(m => m.Location)
                                 .Include(m => m.Event)
                                 .Include(m => m.People)
                                 .Include(m => m.CustomAttributes)
                                 .Where(m => m.Location.Name.ToLower().Contains(searchQuery) || searchQuery.Contains(m.Path.ToLower()));

                addSearchResultToList(foundMedia, media);

                media = ctx.Media.Include(m => m.Location)
                                 .Include(m => m.Event)
                                 .Include(m => m.People)
                                 .Include(m => m.CustomAttributes)
                                 .Where(m => m.Event.Name.ToLower().Contains(searchQuery) || searchQuery.Contains(m.Event.Name.ToLower()));

                addSearchResultToList(foundMedia, media);

                media = ctx.Media.Include(m => m.Location)
                                 .Include(m => m.Event)
                                 .Include(m => m.People)
                                 .Include(m => m.CustomAttributes)
                                 .Where(m => m.People.Any(p => p.Name.ToLower().Contains(searchQuery) || searchQuery.Contains(p.Name.ToLower())));

                addSearchResultToList(foundMedia, media);

                media = ctx.Media.Include(m => m.Location)
                                 .Include(m => m.Event)
                                 .Include(m => m.People)
                                 .Include(m => m.CustomAttributes)
                                 .Where(m => m.CustomAttributes.Any(c => c.Description.ToLower().Contains(searchQuery) || searchQuery.Contains(c.Description.ToLower())));

                addSearchResultToList(foundMedia, media);

                return foundMedia;
            }

        }

        private static void addSearchResultToList(List<Media> foundMedia, IQueryable<Media> media)
        {
            if (media != null)
            {
                foreach (Media m in media)
                {
                    if (!foundMedia.Contains(m))
                        foundMedia.Add(m);
                }
            }
        }
    }
}

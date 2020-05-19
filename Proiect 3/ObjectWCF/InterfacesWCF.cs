using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using WCF;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceMedia
    {
        [OperationContract]
        Media GetMedia(string path);

        [OperationContract]
        bool AddMedia(Media media, List<Person> people, List<CustomAttributes> customAttributes);

        [OperationContract]
        bool UpdateMedia(Media oldMedia, Media newMedia, List<Person> people, List<CustomAttributes> customAttributes);

        [OperationContract]
        int DeleteMedia(Media media);

        [OperationContract]
        List<Media> SearchInDB(String searchKey);

    }

    [ServiceContract]
    interface InterfaceLocation
    {
        [OperationContract]
        bool AddLocation(Location location);
        
        [OperationContract]
        Location GetLocationByName(string name);
    }

    [ServiceContract]
    interface InterfaceEvent
    { 
        [OperationContract]
        bool AddEvent(Event mediaEvent);

        [OperationContract]
        Event GetEventByName(string name);
    }

    [ServiceContract]
    interface InterfacePerson
    {
        [OperationContract]
        bool AddPerson(Person person);
        
        [OperationContract]
        List<string> GetAllPersons();

        [OperationContract]
        Person GetPersonByName(string name);
    }

    [ServiceContract]
    interface InterfaceCustomAttributes
    {
        [OperationContract]
        bool AddCustomAttribute(CustomAttributes customAttribute);
        
        [OperationContract]
        List<string> GetAllAttributes();

        [OperationContract]
        CustomAttributes GetAttributeByDescription(string description);
    }

    [ServiceContract]
    interface IMediaManager: InterfaceMedia, InterfaceCustomAttributes, InterfaceEvent, InterfaceLocation, InterfacePerson
    {
    }
}

﻿using System.ServiceModel;

namespace PeopleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGetPeopleService
    {

        [OperationContract]
        Person[] GetPeopleData(int value);

        [OperationContract]
        PersonMajor[] GetCompletePeople(int value); 

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CryptoServer.Algorithms;
using CryptoServer.Helper;

namespace CryptoServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetData(string value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]
        void AesEncrypt(List<FileExtend> list, byte[] key, byte[] IV, string encFolder, string hashFolder);

        [OperationContract]
        void AesDecrypt(List<FileExtend> list, byte[] key, byte[] IV, string decFolder, string hashFolder);


        [OperationContract]
        void XXTEAEncrypt(List<FileExtend> list, byte[] key, string encFolder, string hashFolder);


        [OperationContract]
        void XXTEADecrypt(List<FileExtend> list, byte[] key, string decFolder, string hashFolder);

        [OperationContract]
        void RC6Encrypt(List<FileExtend> list, byte[] key, string encFolder, string hashFolder);

        [OperationContract]
        void RC6Decrypt(List<FileExtend> list, byte[] key, string decFolder, string hashFolder);

        //-------------- parallel functions

        [OperationContract]
        void AesEncryptP(List<FileExtend> list, byte[] key, byte[] IV, string encFolder, string hashFolder);

        [OperationContract]
        void AesDecryptP(List<FileExtend> list, byte[] key, byte[] IV, string decFolder, string hashFolder);


        [OperationContract]
        void XXTEAEncryptP(List<FileExtend> list, byte[] key, string encFolder, string hashFolder);


        [OperationContract]
        void XXTEADecryptP(List<FileExtend> list, byte[] key, string decFolder, string hashFolder);

        [OperationContract]
        void RC6EncryptP(List<FileExtend> list, byte[] key, string encFolder, string hashFolder);

        [OperationContract]
        void RC6DecryptP(List<FileExtend> list, byte[] key, string decFolder, string hashFolder);


    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "CryptoServer.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

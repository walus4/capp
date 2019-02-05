using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Capgemini.Domain.DTO;

namespace Capgemini.Domain
{
    public class Customer
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public string CompanyName { get; protected set; }
        public string NIP { get; protected set; }
        public string City { get; protected set; }
        public string PostalCode { get; protected set; }
        public string Street { get; protected set; }
        public string HauseNo { get; protected set; }
        public string AppartamentNo { get; protected set; }
        public bool SalesActive { get; protected set; }


        protected Customer()
        {
        }

        public Customer(string name, string surname, string city, string postalCode, string street, string hauseNo,
            string appartamentNo, string companyName, string nip)
        {
            Id = new Guid();
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            City = city ?? throw new ArgumentNullException(nameof(city));
            Street = street ?? throw new ArgumentNullException(nameof(street));
            HauseNo = hauseNo ?? throw new ArgumentNullException(nameof(hauseNo));
            AppartamentNo = appartamentNo ?? throw new ArgumentNullException(nameof(appartamentNo));
            PostalCode = postalCode ?? throw new ArgumentNullException(nameof(postalCode));
            CompanyName = companyName ?? throw new ArgumentNullException(nameof(companyName));
            NIP = CheckValidNIP(nip);
            SalesActive = true;
        }

        public Customer(CustormerDTO modelDTO)
        {
            Id = modelDTO.Id;
            Name = modelDTO.Name;
            Surname = modelDTO.Surname;
            City = modelDTO.City;
            Street = modelDTO.Street;
            HauseNo = modelDTO.HauseNo;
            AppartamentNo = modelDTO.AppartamentNo;
            PostalCode = modelDTO.PostalCode;
            CompanyName = modelDTO.CompanyName;
            NIP = CheckValidNIP(modelDTO.NIP);
            SalesActive = modelDTO.SalesActive;
        }
        public void DeacivateSales()
        {
            SalesActive = false;
        }

        private string CheckValidNIP(string input)
        {
            string intputnumber = Regex.Replace(input, @"-", "");
            int[] weights = {6, 5, 7, 2, 3, 4, 5, 6, 7};
            bool result = false;
            if (intputnumber.Length != 10)
            {
                throw new ValidationException("NIP is not validate");
            }

            int controlSum = CalculateControlSum(intputnumber, weights);
            int controlNum = controlSum % 11;
            if (controlNum == 10)
            {
                throw new ValidationException("NIP is not validate");
            }

            int lastDigit = int.Parse(intputnumber[intputnumber.Length - 1].ToString());
            result = controlNum == lastDigit;
            if (result)
            {
                return input;
            }

            throw new ValidationException("NIP is not validate");
        }

        private int CalculateControlSum(string input, int[] weights, int offset = 0)
        {
            int controlSum = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                controlSum += weights[i + offset] * int.Parse(input[i].ToString());
            }

            return controlSum;
        }
    }
}



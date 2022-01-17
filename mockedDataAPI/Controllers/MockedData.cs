using MainFinanceAPI.Model_Classes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace mockedDataAPI.Controllers
{
    public class MockedData : ControllerBase
    {
        public ILogger<MockedData> logger { get; set; }
        public MockedData(ILogger<MockedData> _logger)
        {
            logger = _logger;
        }
        [HttpGet]
        [Route("mockeddata/listofcompanies")]
        public string ListOfCompanies()
        {
            StreamReader sr = new StreamReader("MockedDataFolder/MockDataList.txt");
            string jsonData = sr.ReadToEnd();
            sr.Close();
            return jsonData;
        }
        [HttpGet]
        [Route("mockeddata/listofratios")]
        public string RatiosData([Optional] string ticker)
        {
            string response = "";
            StreamReader sr = new StreamReader("MockedDataFolder/MockData.txt");
            List<Company> companies = JsonSerializer.Deserialize<List<Company>>(sr.ReadToEnd());
            sr.Close();
            if(ticker == null)
            {
                response = JsonSerializer.Serialize(companies);
                return response;
            }
            else
            {
                Company company = companies.Where(x => x.symbol == ticker).First();
                response = JsonSerializer.Serialize(company);
                return response;
            }
            
        }
        [HttpGet]
        [Route("mockeddata/dcf")]
        public string DCFData([Optional] string ticker)
        {
            string response = "";
            StreamReader sr = new StreamReader("MockedDataFolder/MockDCF.txt");
            List<DCF> dcfList = JsonSerializer.Deserialize<List<DCF>>(sr.ReadToEnd());
            if(ticker == null)
            {
                response = JsonSerializer.Serialize(dcfList);
                return response;
            }
            else
            {
                DCF dcf = dcfList.Where(x => x.symbol == ticker).First();
                response = JsonSerializer.Serialize(dcf);
                return response;
            }
            return "";
        }
    }
}

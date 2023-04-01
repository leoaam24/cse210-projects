using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

public class Forexechange
{
    private double _currencyValue = 0; 
    private double _amount = 0;

    private double _result = 0;

    private bool _statusResult = false;

    public Forexechange()
    {
    }
    public async Task GetValues(string currency_code_from, string currency_code_to)
    {
        // API is only free account. There are 1400 requests left before it runs out of tries. 
        // Requests are made from the time user input after convert to prompt.
        string code = currency_code_from;
        using var client = new HttpClient();
        var listRates = new List<KeyValuePair<string, decimal>>();
        var url = $"https://v6.exchangerate-api.com/v6/0c25af477203b62b98b0bfd3/latest/{code}"; 
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadAsStringAsync();

            var doc = JsonDocument.Parse(data);

            var rateObjects = doc.RootElement.GetProperty("conversion_rates");
            foreach (var rate in rateObjects.EnumerateObject())
            {
                var kvp = new KeyValuePair<string, decimal>(rate.Name, rate.Value.GetDecimal());
                listRates.Add(kvp);
            }

            foreach (var rate in listRates)
            {  
                string rateKey = (rate.Key).ToString();
                if (rateKey == currency_code_to)
                {
                   string _value = (rate.Value).ToString();
                   double value = double.Parse(_value);
                   _currencyValue = value;
                   _result = _amount * _currencyValue;
                   _statusResult = true;

                Console.WriteLine($"{rateKey} : {_result}");
                Console.WriteLine("Please enter to continue...");
                }
            }
            
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
        } 
    }

    public void setAmount(double data)
    {
        _amount = data;
    }

    public double getResult()
    {
        return _result;
    }

    public bool getStatusResult()
    {
        return _statusResult;
    }
}
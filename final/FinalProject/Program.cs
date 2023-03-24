using System;

class Program
{
    static void Main(string[] args)
    {
        int startProgram = 1;

        while (startProgram == 1)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Many-in-One Unit Converter");
            Console.WriteLine();
            Console.WriteLine("Please select the measurement category that you want to start converting: ");
            Console.WriteLine();
            Console.WriteLine("1. Temperature");
            Console.WriteLine("2. Length 1");
            Console.WriteLine("3. Length 2");
            Console.WriteLine("4. Weight");
            Console.WriteLine("5. Area");
            Console.WriteLine("6. Calculator");
            Console.WriteLine("7. Quit");
            Console.Write("Enter your choice: ");
            string _userChoice = Console.ReadLine();
            int userChoice = int.Parse(_userChoice);

            if (userChoice == 1)  // ------------------------------------------------- TEMPERATURE
            {
                Temperature TempClass = new Temperature();
                int conversionFrom = TempClass.conversionFrom();
                int conversionTo = 0;
                if (conversionFrom == 1)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (TempClass.getList())[index];
                    conversionTo = TempClass.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        string userPickTo = (TempClass.getList())[index];
                        Console.Clear();
                        double userInput = TempClass.fromEntry($"{userPickFrom}");
                        TempClass.SetCelsius(userInput);
                        double result = TempClass.ConvertCtoF();
                        TempClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = conversionFrom;
                        string userPickTo = (TempClass.getList())[index];
                        Console.Clear();
                        double userInput = TempClass.fromEntry($"{userPickFrom}");
                        TempClass.SetCelsius(userInput);
                        double result = TempClass.ConvertCtoK();
                        TempClass.toEntry($"{userPickTo}", result);
                    }
                }
                else if (conversionFrom == 2)
                {
                    int index = (conversionFrom) - 1;
                    string userPickFrom = (TempClass.getList())[index];
                    conversionTo = TempClass.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (TempClass.getList())[index];
                        Console.Clear();
                        double userInput = TempClass.fromEntry($"{userPickFrom}");
                        TempClass.SetFahrenheit(userInput);
                        double result = TempClass.ConvertFtoC();
                        TempClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = conversionFrom - 1;
            
                        string userPickTo = (TempClass.getList())[index];
                        Console.Clear();
                        double userInput = TempClass.fromEntry($"{userPickFrom}");
                        TempClass.SetFahrenheit(userInput);
                        double result = TempClass.ConvertFtoK();
                        TempClass.toEntry($"{userPickTo}", result);
                    }
                    
                }
                else if (conversionFrom == 3)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (TempClass.getList())[index];
                    conversionTo = TempClass.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 3;
                        string userPickTo = (TempClass.getList())[index];
                        Console.Clear();
                        double userInput = TempClass.fromEntry($"{userPickFrom}");
                        TempClass.SetKelvin(userInput);
                        double result = TempClass.ConvertKtoC();
                        TempClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (TempClass.getList())[index];
                        Console.Clear();
                        double userInput = TempClass.fromEntry($"{userPickFrom}");
                        TempClass.SetKelvin(userInput);
                        double result = TempClass.ConvertKtoF();
                        TempClass.toEntry($"{userPickTo}", result);
                    }
                }
            }

            else if (userChoice == 2) // -----------------------------------------------> MEASUREMENT 1
            {
                Measurement1 M1Class = new Measurement1();
                Measurement2 M2Class = new Measurement2();
                int conversionFrom = M1Class.conversionFrom();
                int conversionTo = 0;
                if (conversionFrom == 1)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (M1Class.getList())[index];
                    conversionTo = M1Class.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        string userPickTo = (M1Class.getList())[index];
                        Console.Clear();
                        double userInput = M1Class.fromEntry($"{userPickFrom}");
                        M1Class.setInches(userInput);
                        double result = M1Class.ConvertInchTocm();
                        M1Class.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = conversionFrom;
                        string userPickTo = (M1Class.getList())[index];
                        Console.Clear();
                        double userInput = M1Class.fromEntry($"{userPickFrom}");
                        M1Class.setInches(userInput);
                        double result = M1Class.ConvertInchTomm();
                        M1Class.toEntry($"{userPickTo}", result);
                    }
                }
                else if (conversionFrom == 2)
                {
                    int index = (conversionFrom) - 1;
                    string userPickFrom = (M1Class.getList())[index];
                    conversionTo = M1Class.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (M1Class.getList())[index];
                        Console.Clear();
                        double userInput = M1Class.fromEntry($"{userPickFrom}");
                        M1Class.setCentimeter(userInput);
                        double result = M1Class.ConvertcmToInch();
                        M1Class.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = conversionFrom - 1;
                        string userPickTo = (M1Class.getList())[index];
                        Console.Clear();
                        double userInput = M1Class.fromEntry($"{userPickFrom}");
                        M1Class.setCentimeter(userInput);
                        double result = M1Class.ConvercmTomm();
                        M1Class.toEntry($"{userPickTo}", result);
                    }
                    
                }
                else if (conversionFrom == 3)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (M1Class.getList())[index];
                    conversionTo = M1Class.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 3;
                        string userPickTo = (M1Class.getList())[index];
                        Console.Clear();
                        double userInput = M1Class.fromEntry($"{userPickFrom}");
                        M1Class.setMillimeter(userInput);
                        double result = M1Class.ConvertmmToInch();
                        M1Class.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (M1Class.getList())[index];
                        Console.Clear();
                        double userInput = M1Class.fromEntry($"{userPickFrom}");
                        M1Class.setMillimeter(userInput);
                        double result = M1Class.ConvertmmTocm();
                        M1Class.toEntry($"{userPickTo}", result);
                    }
                }


            }

            else if (userChoice == 3) // -----------------------------------------------> MEASUREMENT 2
            {
                Measurement2 M2Class = new Measurement2();
                int conversionFrom = M2Class.conversionFrom();
                int conversionTo = 0;
                if (conversionFrom == 1)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (M2Class.getList())[index];
                    conversionTo = M2Class.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        string userPickTo = (M2Class.getList())[index];
                        Console.Clear();
                        double userInput = M2Class.fromEntry($"{userPickFrom}");
                        M2Class.setFoot(userInput);
                        double result = M2Class.ConvertfootTom();
                        M2Class.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = conversionFrom;
                        string userPickTo = (M2Class.getList())[index];
                        Console.Clear();
                        double userInput = M2Class.fromEntry($"{userPickFrom}");
                        M2Class.setFoot(userInput);
                        double result = M2Class.ConvertfootToKilometer();
                        M2Class.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 3)
                    {
                        index = conversionFrom;
                        string userPickTo = (M2Class.getList())[index];
                        Console.Clear();
                        double userInput = M2Class.fromEntry($"{userPickFrom}");
                        M2Class.setFoot(userInput);
                        double result = M2Class.ConvertfootTomiles();
                        M2Class.toEntry($"{userPickTo}", result);
                    }
                }
                else if (conversionFrom == 2)
                {
                    int index = (conversionFrom) - 1;
                    string userPickFrom = (M2Class.getList())[index];
                    conversionTo = M2Class.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (M2Class.getList())[index];
                        Console.Clear();
                        double userInput = M2Class.fromEntry($"{userPickFrom}");
                        M2Class.setMeter(userInput);
                        double result = M2Class.ConvertmTofoot();
                        M2Class.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = conversionFrom - 1;
                        string userPickTo = (M2Class.getList())[index];
                        Console.Clear();
                        double userInput = M2Class.fromEntry($"{userPickFrom}");
                        M2Class.setMeter(userInput);
                        double result = M2Class.ConvertmtoKilometers();
                        M2Class.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 3)
                    {
                        index = conversionFrom - 1;
                        string userPickTo = (M2Class.getList())[index];
                        Console.Clear();
                        double userInput = M2Class.fromEntry($"{userPickFrom}");
                        M2Class.setMeter(userInput);
                        double result = M2Class.ConvertfootTomiles();
                        M2Class.toEntry($"{userPickTo}", result);
                    }
                    
                }
                
                else if (conversionFrom == 3)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (M2Class.getList())[index];
                    conversionTo = M2Class.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 3;
                        string userPickTo = (M2Class.getList())[index];
                        Console.Clear();
                        double userInput = M2Class.fromEntry($"{userPickFrom}");
                        M2Class.setKilometer(userInput);
                        double result = M2Class.ConvertKmTofoot();
                        M2Class.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (M2Class.getList())[index];
                        Console.Clear();
                        double userInput = M2Class.fromEntry($"{userPickFrom}");
                        M2Class.setKilometer(userInput);
                        double result = M2Class.ConvertKmTom();
                        M2Class.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 3)
                    {
                        index = (conversionFrom) - 1;
                        string userPickTo = (M2Class.getList())[index];
                        Console.Clear();
                        double userInput = M2Class.fromEntry($"{userPickFrom}");
                        M2Class.setKilometer(userInput);
                        double result = M2Class.ConvertKmToMi();
                        M2Class.toEntry($"{userPickTo}", result);
                    }
                }

                else if (conversionFrom == 4)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (M2Class.getList())[index];
                    conversionTo = M2Class.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 4;
                        string userPickTo = (M2Class.getList())[index];
                        Console.Clear();
                        double userInput = M2Class.fromEntry($"{userPickFrom}");
                        M2Class.setMiles(userInput);
                        double result = M2Class.ConvertmiTofoot();
                        M2Class.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = (conversionFrom) - 3;
                        string userPickTo = (M2Class.getList())[index];
                        Console.Clear();
                        double userInput = M2Class.fromEntry($"{userPickFrom}");
                        M2Class.setMiles(userInput);
                        double result = M2Class.ConvertmiTom();
                        M2Class.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 3)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (M2Class.getList())[index];
                        Console.Clear();
                        double userInput = M2Class.fromEntry($"{userPickFrom}");
                        M2Class.setMiles(userInput);
                        double result = M2Class.ConvertmiToKm();
                        M2Class.toEntry($"{userPickTo}", result);
                    }
                }
            }

            else if (userChoice == 4) // -----------------------------------------------> WEIGHT
            {
                Weight WClass = new Weight();
                int conversionFrom = WClass.conversionFrom();
                int conversionTo = 0;
                if (conversionFrom == 1)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (WClass.getList())[index];
                    conversionTo = WClass.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        string userPickTo = (WClass.getList())[index];
                        Console.Clear();
                        double userInput = WClass.fromEntry($"{userPickFrom}");
                        WClass.setMilliGrams(userInput);
                        double result = WClass.ConvertmgTog();
                        WClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = conversionFrom;
                        string userPickTo = (WClass.getList())[index];
                        Console.Clear();
                        double userInput = WClass.fromEntry($"{userPickFrom}");
                        WClass.setMilliGrams(userInput);
                        double result = WClass.ConvertmgTokg();
                        WClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 3)
                    {
                        index = conversionFrom;
                        string userPickTo = (WClass.getList())[index];
                        Console.Clear();
                        double userInput = WClass.fromEntry($"{userPickFrom}");
                        WClass.setMilliGrams(userInput);
                        double result = WClass.ConvertmgTolb();
                        WClass.toEntry($"{userPickTo}", result);
                    }
                }
                else if (conversionFrom == 2)
                {
                    int index = (conversionFrom) - 1;
                    string userPickFrom = (WClass.getList())[index];
                    conversionTo = WClass.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (WClass.getList())[index];
                        Console.Clear();
                        double userInput = WClass.fromEntry($"{userPickFrom}");
                        WClass.setGram(userInput);
                        double result = WClass.ConvergTomg();
                        WClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = conversionFrom - 1;
                        string userPickTo = (WClass.getList())[index];
                        Console.Clear();
                        double userInput = WClass.fromEntry($"{userPickFrom}");
                        WClass.setGram(userInput);
                        double result = WClass.Convertgtokg();
                        WClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 3)
                    {
                        index = conversionFrom - 1;
                        string userPickTo = (WClass.getList())[index];
                        Console.Clear();
                        double userInput = WClass.fromEntry($"{userPickFrom}");
                        WClass.setGram(userInput);
                        double result = WClass.ConvertgTolb();
                        WClass.toEntry($"{userPickTo}", result);
                    }
                    
                }
                
                else if (conversionFrom == 3)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (WClass.getList())[index];
                    conversionTo = WClass.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 3;
                        string userPickTo = (WClass.getList())[index];
                        Console.Clear();
                        double userInput = WClass.fromEntry($"{userPickFrom}");
                        WClass.setKiloGram(userInput);
                        double result = WClass.ConvertkgTomg();
                        WClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (WClass.getList())[index];
                        Console.Clear();
                        double userInput = WClass.fromEntry($"{userPickFrom}");
                        WClass.setKiloGram(userInput);
                        double result = WClass.ConvertkgTog();
                        WClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 3)
                    {
                        index = (conversionFrom) - 1;
                        string userPickTo = (WClass.getList())[index];
                        Console.Clear();
                        double userInput = WClass.fromEntry($"{userPickFrom}");
                        WClass.setKiloGram(userInput);
                        double result = WClass.ConvertkgTolb();
                        WClass.toEntry($"{userPickTo}", result);
                    }
                }

                else if (conversionFrom == 4)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (WClass.getList())[index];
                    conversionTo = WClass.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 4;
                        string userPickTo = (WClass.getList())[index];
                        Console.Clear();
                        double userInput = WClass.fromEntry($"{userPickFrom}");
                        WClass.setPounds(userInput);
                        double result = WClass.ConvertlbTomg();
                        WClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = (conversionFrom) - 3;
                        string userPickTo = (WClass.getList())[index];
                        Console.Clear();
                        double userInput = WClass.fromEntry($"{userPickFrom}");
                        WClass.setPounds(userInput);
                        double result = WClass.ConvertlbTog();
                        WClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 3)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (WClass.getList())[index];
                        Console.Clear();
                        double userInput = WClass.fromEntry($"{userPickFrom}");
                        WClass.setPounds(userInput);
                        double result = WClass.ConvertlbTokg();
                        WClass.toEntry($"{userPickTo}", result);
                    }
                }
            }    

            else if (userChoice == 5) // -----------------------------------------------> AREA
            {
                Area AClass = new Area();
                int conversionFrom = AClass.conversionFrom();
                int conversionTo = 0;
                if (conversionFrom == 1)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (AClass.getList())[index];
                    conversionTo = AClass.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        string userPickTo = (AClass.getList())[index];
                        Console.Clear();
                        double userInput = AClass.fromEntry($"{userPickFrom}");
                        AClass.setSquareM(userInput);
                        double result = AClass.ConvertSqmToSqft();
                        AClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = conversionFrom;
                        string userPickTo = (AClass.getList())[index];
                        Console.Clear();
                        double userInput = AClass.fromEntry($"{userPickFrom}");
                        AClass.setSquareM(userInput);
                        double result = AClass.ConvertsqmTohectar();
                        AClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 3)
                    {
                        index = conversionFrom;
                        string userPickTo = (AClass.getList())[index];
                        Console.Clear();
                        double userInput = AClass.fromEntry($"{userPickFrom}");
                        AClass.setSquareM(userInput);
                        double result = AClass.ConvertsqmTosqyrds();
                        AClass.toEntry($"{userPickTo}", result);
                    }
                }
                else if (conversionFrom == 2)
                {
                    int index = (conversionFrom) - 1;
                    string userPickFrom = (AClass.getList())[index];
                    conversionTo = AClass.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (AClass.getList())[index];
                        Console.Clear();
                        double userInput = AClass.fromEntry($"{userPickFrom}");
                        AClass.setSquareFt(userInput);
                        double result = AClass.ConvertsqftTosqm();
                        AClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = conversionFrom - 1;
                        string userPickTo = (AClass.getList())[index];
                        Console.Clear();
                        double userInput = AClass.fromEntry($"{userPickFrom}");
                        AClass.setSquareFt(userInput);
                        double result = AClass.Convertsqfttohectar();
                        AClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 3)
                    {
                        index = conversionFrom - 1;
                        string userPickTo = (AClass.getList())[index];
                        Console.Clear();
                        double userInput = AClass.fromEntry($"{userPickFrom}");
                        AClass.setSquareFt(userInput);
                        double result = AClass.ConvertsqftTosqyrds();
                        AClass.toEntry($"{userPickTo}", result);
                    }
                    
                }
                
                else if (conversionFrom == 3)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (AClass.getList())[index];
                    conversionTo = AClass.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 3;
                        string userPickTo = (AClass.getList())[index];
                        Console.Clear();
                        double userInput = AClass.fromEntry($"{userPickFrom}");
                        AClass.setHectar(userInput);
                        double result = AClass.ConverthectarTosqm();
                        AClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (AClass.getList())[index];
                        Console.Clear();
                        double userInput = AClass.fromEntry($"{userPickFrom}");
                        AClass.setHectar(userInput);
                        double result = AClass.ConverthectarTosqft();
                        AClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 3)
                    {
                        index = (conversionFrom) - 1;
                        string userPickTo = (AClass.getList())[index];
                        Console.Clear();
                        double userInput = AClass.fromEntry($"{userPickFrom}");
                        AClass.setHectar(userInput);
                        double result = AClass.ConverthectarTosqyrds();
                        AClass.toEntry($"{userPickTo}", result);
                    }
                }

                else if (conversionFrom == 4)
                {
                    int index = conversionFrom - 1;
                    string userPickFrom = (AClass.getList())[index];
                    conversionTo = AClass.conversionTo($"{userPickFrom}");
                    if (conversionTo == 1)
                    {
                        index = (conversionFrom) - 4;
                        string userPickTo = (AClass.getList())[index];
                        Console.Clear();
                        double userInput = AClass.fromEntry($"{userPickFrom}");
                        AClass.setSqYards(userInput);
                        double result = AClass.ConvertsqyrdsTosqm();
                        AClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 2)
                    {
                        index = (conversionFrom) - 3;
                        string userPickTo = (AClass.getList())[index];
                        Console.Clear();
                        double userInput = AClass.fromEntry($"{userPickFrom}");
                        AClass.setSqYards(userInput);
                        double result = AClass.ConvertsqyrdsTosqft();
                        AClass.toEntry($"{userPickTo}", result);
                    }

                    else if (conversionTo == 3)
                    {
                        index = (conversionFrom) - 2;
                        string userPickTo = (AClass.getList())[index];
                        Console.Clear();
                        double userInput = AClass.fromEntry($"{userPickFrom}");
                        AClass.setSqYards(userInput);
                        double result = AClass.ConvertsqyrdsTohectar();
                        AClass.toEntry($"{userPickTo}", result);
                    }
                }    
            }

            else
            {
                startProgram = 0;
            }
        }
        
    }
}
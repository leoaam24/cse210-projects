using System;

class Program
{
    static void Main(string[] args)
    {
        int startProgram = 1;
        double PreviousResult = 0;
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
            Console.WriteLine("7. Currency (Need to be Online)");
            Console.WriteLine("8. Quit");
            Console.Write("Enter your choice: ");
            string _userChoice = Console.ReadLine();
            if (!(String.IsNullOrEmpty(_userChoice)))
            {
                int userChoice = int.Parse(_userChoice);
                if (userChoice == 1)  // ------------------------------------------------- TEMPERATURE
            {
                Temperature TempClass = new Temperature();
                int conversionFrom = TempClass.conversionFrom();
                int conversionTo = 0;

                switch (conversionFrom)
                {
                    case 1: // Celsius
                        string userPickFromC = (TempClass.getList())[0];
                        conversionTo = TempClass.conversionTo(userPickFromC);

                        switch (conversionTo)
                        {
                            case 1: // Celsius to Fahrenheit
                                Console.Clear();
                                string userPickToCF = (TempClass.getList())[0];
                                double userInputCF = TempClass.fromEntry(userPickFromC);
                                double resultCF = TempClass.ConvertCtoF(userInputCF);
                                TempClass.toEntry(userPickToCF, resultCF);
                                break;

                            case 2: // Celsius to Kelvin
                                Console.Clear();
                                string userPickToCK = (TempClass.getList())[1];
                                double userInputCK = TempClass.fromEntry(userPickFromC);
                                double resultCK = TempClass.ConvertCtoK(userInputCK);
                                TempClass.toEntry(userPickToCK, resultCK);
                                break;
                        }
                        break;

                    case 2: // Fahrenheit
                        string userPickFromF = (TempClass.getList())[1];
                        conversionTo = TempClass.conversionTo(userPickFromF);

                        switch (conversionTo)
                        {
                            case 1: // Fahrenheit to Celsius
                                Console.Clear();
                                string userPickToFC = (TempClass.getList())[0];
                                double userInputFC = TempClass.fromEntry(userPickFromF);
                                double resultFC = TempClass.ConvertFtoC(userInputFC);
                                TempClass.toEntry(userPickToFC, resultFC);
                                break;

                            case 2: // Fahrenheit to Kelvin
                                Console.Clear();
                                string userPickToFK = (TempClass.getList())[1];
                                double userInputFK = TempClass.fromEntry(userPickFromF);
                                double resultFK = TempClass.ConvertFtoK(userInputFK);
                                TempClass.toEntry(userPickToFK, resultFK);
                                break;
                        }
                        break;

                    case 3: // Kelvin
                        string userPickFromK = (TempClass.getList())[2];
                        conversionTo = TempClass.conversionTo(userPickFromK);

                        switch (conversionTo)
                        {
                            case 1: // Kelvin to Celsius
                                Console.Clear();
                                string userPickToKC = (TempClass.getList())[0];
                                double userInputKC = TempClass.fromEntry(userPickFromK);
                                double resultKC = TempClass.ConvertKtoC(userInputKC);
                                TempClass.toEntry(userPickToKC, resultKC);
                                break;

                            case 2: // Kelvin to Fahrenheit
                                Console.Clear();
                                string userPickToKF = (TempClass.getList())[1];
                                double userInputKF = TempClass.fromEntry(userPickFromK);
                                double resultKF = TempClass.ConvertKtoF(userInputKF);
                                TempClass.toEntry(userPickToKF, resultKF);
                                break;
                        }
                        break;
                }

            }

            else if (userChoice == 2) // -----------------------------------------------> MEASUREMENT 1
            {
                Measurement1 M1Class = new Measurement1();
                int conversionFrom = M1Class.conversionFrom();
                int conversionTo = 0;
                switch (conversionFrom)
                {
                    case 1: // Inch
                        string userPickFromInch = (M1Class.getList())[0];
                        conversionTo = M1Class.conversionTo(userPickFromInch);

                        switch (conversionTo)
                        {
                            case 1: // Inch to Centimeter
                                Console.Clear();
                                string userPickToInCm = (M1Class.getList())[0];
                                double userInputInCm = M1Class.fromEntry(userPickFromInch);
                                double resultInCm = M1Class.ConvertInchTocm(userInputInCm);
                                M1Class.toEntry(userPickToInCm, resultInCm);
                                break;

                            case 2: // Inch to Millimeter
                                Console.Clear();
                                string userPickToInMm = (M1Class.getList())[1];
                                double userInputInMm = M1Class.fromEntry(userPickFromInch);
                                double resultInMm = M1Class.ConvertInchTomm(userInputInMm);
                                M1Class.toEntry(userPickToInMm, resultInMm);
                                break;
                        }
                        break;

                    case 2: // Centimeter
                        string userPickFromCm = (M1Class.getList())[1];
                        conversionTo = M1Class.conversionTo(userPickFromCm);

                        switch (conversionTo)
                        {
                            case 1: // Centimeter to Inch
                                Console.Clear();
                                string userPickToCmIn = (M1Class.getList())[0];
                                double userInputCmIn = M1Class.fromEntry(userPickFromCm);
                                double resultCmIn = M1Class.ConvertcmToInch(userInputCmIn);
                                M1Class.toEntry(userPickToCmIn, resultCmIn);
                                break;

                            case 2: // Centimeter to Millimeter
                                Console.Clear();
                                string userPickToCmMm = (M1Class.getList())[1];
                                double userInputCmMm = M1Class.fromEntry(userPickFromCm);
                                double resultCmMm = M1Class.ConvercmTomm(userInputCmMm);
                                M1Class.toEntry(userPickToCmMm, resultCmMm);
                                break;
                        }
                        break;

                    case 3: // Millimeter
                        string userPickFromMm = (M1Class.getList())[2];
                        conversionTo = M1Class.conversionTo(userPickFromMm);

                        switch (conversionTo)
                        {
                            case 1: // Millimeter to Inch
                                Console.Clear();
                                string userPickToMmIn = (M1Class.getList())[0];
                                double userInputMmIn = M1Class.fromEntry(userPickFromMm);
                                double resultMmIn = M1Class.ConvertmmToInch(userInputMmIn);
                                M1Class.toEntry(userPickToMmIn, resultMmIn);
                                break;

                            case 2: // Millimeter to Centimeter
                                Console.Clear();
                                string userPickToMmCm = (M1Class.getList())[1];
                                double userInputMmCm = M1Class.fromEntry(userPickFromMm);
                                double resultMmCm = M1Class.ConvertmmTocm(userInputMmCm);
                                M1Class.toEntry(userPickToMmCm, resultMmCm);
                                break;
                        }
                        break;
                }

            }

            else if (userChoice == 3) // -----------------------------------------------> MEASUREMENT 2
            {
                Measurement2 M2Class = new Measurement2();
                int conversionFrom = M2Class.conversionFrom();
                int conversionTo = 0;
                switch (conversionFrom)
                {
                    case 1: // Foot
                        string userPickFromFt = (M2Class.getList())[0];
                        conversionTo = M2Class.conversionTo(userPickFromFt);

                        switch (conversionTo)
                        {
                            case 1: // Foot to Meter
                                Console.Clear();
                                string userPickToFtM = (M2Class.getList())[0];
                                double userInputFtM = M2Class.fromEntry(userPickFromFt);
                                double resultFtM = M2Class.ConvertfootTom(userInputFtM);
                                M2Class.toEntry(userPickToFtM, resultFtM);
                                break;

                            case 2: // Foot to Kilometer
                                Console.Clear();
                                string userPickToFtKm = (M2Class.getList())[1];
                                double userInputFtKm = M2Class.fromEntry(userPickFromFt);
                                double resultFtKm = M2Class.ConvertfootToKilometer(userInputFtKm);
                                M2Class.toEntry(userPickToFtKm, resultFtKm);
                                break;
                            case 3: // Foot to Miles
                                Console.Clear();
                                string userPickToFtMi = (M2Class.getList())[2];
                                double userInputFtMi = M2Class.fromEntry(userPickFromFt);
                                double resultFtMi = M2Class.ConvertfootTomiles(userInputFtMi);
                                M2Class.toEntry(userPickToFtMi, resultFtMi);
                                break;
                        }
                        break;

                    case 2: // Meter
                        string userPickFromM = (M2Class.getList())[1];
                        conversionTo = M2Class.conversionTo(userPickFromM);

                        switch (conversionTo)
                        {
                            case 1: // Meter to Foot
                                Console.Clear();
                                string userPickToMF = (M2Class.getList())[0];
                                double userInputMF = M2Class.fromEntry(userPickFromM);
                                double resultMF = M2Class.ConvertmTofoot(userInputMF);
                                M2Class.toEntry(userPickToMF, resultMF);
                                break;

                            case 2: // Meter to Kilometer
                                Console.Clear();
                                string userPickToMKm = (M2Class.getList())[1];
                                double userInputMKm= M2Class.fromEntry(userPickFromM);
                                double resultMKm = M2Class.ConvertmtoKilometers(userInputMKm);
                                M2Class.toEntry(userPickToMKm, resultMKm);
                                break;
                            case 3: // Meter to Miles
                                Console.Clear();
                                string userPickToMMi= (M2Class.getList())[1];
                                double userInputMMi= M2Class.fromEntry(userPickFromM);
                                double resultMMi = M2Class.ConvertmToMiles(userInputMMi);
                                M2Class.toEntry(userPickToMMi, resultMMi);
                                break;
                        }
                        break;

                    case 3: // Kilometer
                        string userPickFromKm = (M2Class.getList())[2];
                        conversionTo = M2Class.conversionTo(userPickFromKm);

                        switch (conversionTo)
                        {
                            case 1: // Kilometer to Foot
                                Console.Clear();
                                string userPickToKmFt = (M2Class.getList())[0];
                                double userInputKmFt = M2Class.fromEntry(userPickFromKm);
                                double resultKmFt= M2Class.ConvertKmTofoot(userInputKmFt);
                                M2Class.toEntry(userPickToKmFt, resultKmFt);
                                break;

                            case 2: // Kilometer to Meter
                                Console.Clear();
                                string userPickToKmM = (M2Class.getList())[1];
                                double userInputKmM = M2Class.fromEntry(userPickFromKm);
                                double resultKmM  = M2Class.ConvertKmTom(userInputKmM);
                                M2Class.toEntry(userPickToKmM , resultKmM );
                                break;
                            case 3: // Kilometer to Miles
                                Console.Clear();
                                string userPickToKmMi = (M2Class.getList())[2];
                                double userInputKmMi = M2Class.fromEntry(userPickFromKm);
                                double resultKmMi  = M2Class.ConvertKmToMi(userInputKmMi);
                                M2Class.toEntry(userPickToKmMi , resultKmMi);
                                break;
                        }
                        break;

                        case 4: // Miles
                        string userPickFromMi = (M2Class.getList())[3];
                        conversionTo = M2Class.conversionTo(userPickFromMi);

                        switch (conversionTo)
                        {
                            case 1: // Miles to Foot
                                Console.Clear();
                                string userPickToMiFt = (M2Class.getList())[0];
                                double userInputMiFt = M2Class.fromEntry(userPickFromMi);
                                double resultMiFt= M2Class.ConvertmiTofoot(userInputMiFt);
                                M2Class.toEntry(userPickToMiFt, resultMiFt);
                                break;

                            case 2: // Miles to Meter
                                Console.Clear();
                                string userPickToMiM = (M2Class.getList())[1];
                                double userInputMiM = M2Class.fromEntry(userPickFromMi);
                                double resultMiM = M2Class.ConvertmiTom(userInputMiM);
                                M2Class.toEntry(userPickToMiM , resultMiM);
                                break;

                            case 3: // Miles to Kilometer
                                Console.Clear();
                                string userPickToMiKm = (M2Class.getList())[2];
                                double userInputMiKm = M2Class.fromEntry(userPickFromMi);
                                double resultMiKm = M2Class.ConvertmiToKm(userInputMiKm);
                                M2Class.toEntry(userPickToMiKm , resultMiKm);
                                break;
                        }
                        break;
                }
            }

            else if (userChoice == 4) // -----------------------------------------------> WEIGHT
            {
                Weight WClass = new Weight();
                int conversionFrom = WClass.conversionFrom();
                int conversionTo = 0;
                switch (conversionFrom)
                {
                    case 1: // Milligrams
                        string userPickFromMg = (WClass.getList())[0];
                        conversionTo = WClass.conversionTo(userPickFromMg);

                        switch (conversionTo)
                        {
                            case 1: // Milligrams to Grams
                                Console.Clear();
                                string userPickToMgGm = (WClass.getList())[0];
                                double userInputMgGm = WClass.fromEntry(userPickFromMg);
                                double resultMgGm = WClass.ConvertmgTog(userInputMgGm);
                                WClass.toEntry(userPickToMgGm, resultMgGm);
                                break;

                            case 2: // Milligrams to Kilograms
                                Console.Clear();
                                string userPickToMgKg = (WClass.getList())[1];
                                double userInputMgKg = WClass.fromEntry(userPickFromMg);
                                double resultMgKg = WClass.ConvertmgTokg(userInputMgKg);
                                WClass.toEntry(userPickToMgKg, resultMgKg);
                                break;
                            case 3: // Milligrams to Pounds
                                Console.Clear();
                                string userPickToMgLb = (WClass.getList())[2];
                                double userInputMgLb = WClass.fromEntry(userPickFromMg);
                                double resultMgLb = WClass.ConvertmgTolb(userInputMgLb);
                                WClass.toEntry(userPickToMgLb, resultMgLb);
                                break;
                        }
                        break;

                    case 2: // Grams
                        string userPickFromG = (WClass.getList())[1];
                        conversionTo = WClass.conversionTo(userPickFromG);

                        switch (conversionTo)
                        {
                            case 1: // Grams to Milligrams
                                Console.Clear();
                                string userPickToGMg = (WClass.getList())[0];
                                double userInputGMg = WClass.fromEntry(userPickFromG);
                                double resultGMg = WClass.ConvergTomg(userInputGMg);
                                WClass.toEntry(userPickToGMg, resultGMg);
                                break;

                            case 2: // Grams to Kilograms
                                Console.Clear();
                                string userPickToGKg= (WClass.getList())[1];
                                double userInputGKg= WClass.fromEntry(userPickFromG);
                                double resultGKg = WClass.Convertgtokg(userInputGKg);
                                WClass.toEntry(userPickToGKg, resultGKg);
                                break;
                            case 3: // Grams to Pounds
                                Console.Clear();
                                string userPickToGLb= (WClass.getList())[1];
                                double userInputGLb= WClass.fromEntry(userPickFromG);
                                double resultGLb = WClass.ConvertgTolb(userInputGLb);
                                WClass.toEntry(userPickToGLb, resultGLb);
                                break;
                        }
                        break;

                    case 3: // Kilograms
                        string userPickFromKg = (WClass.getList())[2];
                        conversionTo = WClass.conversionTo(userPickFromKg);

                        switch (conversionTo)
                        {
                            case 1: // Kilograms to Milligrams
                                Console.Clear();
                                string userPickToKmMg = (WClass.getList())[0];
                                double userInputKmMg = WClass.fromEntry(userPickFromKg);
                                double resultKmMg= WClass.ConvertkgTomg(userInputKmMg);
                                WClass.toEntry(userPickToKmMg, resultKmMg);
                                break;

                            case 2: // Kilograms to Grams
                                Console.Clear();
                                string userPickToKgG = (WClass.getList())[1];
                                double userInputKgG = WClass.fromEntry(userPickFromKg);
                                double resultKgG  = WClass.ConvertkgTog(userInputKgG);
                                WClass.toEntry(userPickToKgG , resultKgG );
                                break;
                            case 3: // Kilograms to Pounds
                                Console.Clear();
                                string userPickToKgLb = (WClass.getList())[2];
                                double userInputKgLb = WClass.fromEntry(userPickFromKg);
                                double resultKgLb  = WClass.ConvertkgTolb(userInputKgLb);
                                WClass.toEntry(userPickToKgLb , resultKgLb);
                                break;
                        }
                        break;

                        case 4: // Pounds
                        string userPickFromLb = (WClass.getList())[3];
                        conversionTo = WClass.conversionTo(userPickFromLb);

                        switch (conversionTo)
                        {
                            case 1: // Pounds to Milligrams
                                Console.Clear();
                                string userPickToLbMg = (WClass.getList())[0];
                                double userInputLbMg = WClass.fromEntry(userPickFromLb);
                                double resultLbMg= WClass.ConvertlbTomg(userInputLbMg);
                                WClass.toEntry(userPickToLbMg, resultLbMg);
                                break;

                            case 2: // Pounds to Grams
                                Console.Clear();
                                string userPickToLbG = (WClass.getList())[1];
                                double userInputLbG = WClass.fromEntry(userPickFromLb);
                                double resultLbG = WClass.ConvertlbTog(userInputLbG);
                                WClass.toEntry(userPickToLbG , resultLbG);
                                break;

                            case 3: // Pounds to Kilograms
                                Console.Clear();
                                string userPickToLbKg = (WClass.getList())[2];
                                double userInputLbKg = WClass.fromEntry(userPickFromLb);
                                double resultLbKg = WClass.ConvertlbTokg(userInputLbKg);
                                WClass.toEntry(userPickToLbKg , resultLbKg);
                                break;
                        }
                        break;
                }
            }    

            else if (userChoice == 5) // -----------------------------------------------> AREA
            {
                Area AClass = new Area();
                int conversionFrom = AClass.conversionFrom();
                int conversionTo = 0;
                switch (conversionFrom)
                {
                    case 1: // Square Meter
                        string userPickFromSqm = (AClass.getList())[0];
                        conversionTo = AClass.conversionTo(userPickFromSqm);

                        switch (conversionTo)
                        {
                            case 1: // Square Meter to Square Foot
                                Console.Clear();
                                string userPickToSqmSqft = (AClass.getList())[0];
                                double userInputSqmSqft = AClass.fromEntry(userPickFromSqm);
                                double resultSqmSqft = AClass.ConvertSqmToSqft(userInputSqmSqft);
                                AClass.toEntry(userPickToSqmSqft, resultSqmSqft);
                                break;

                            case 2: // Square Meter to Hectares
                                Console.Clear();
                                string userPickToSqmH = (AClass.getList())[1];
                                double userInputSqmH = AClass.fromEntry(userPickFromSqm);
                                double resultSqmH = AClass.ConvertsqmTohectar(userInputSqmH);
                                AClass.toEntry(userPickToSqmH, resultSqmH);
                                break;
                            case 3: // Square Meter to Square Yards
                                Console.Clear();
                                string userPickToSqmSqY = (AClass.getList())[2];
                                double userInputSqmSqY = AClass.fromEntry(userPickFromSqm);
                                double resultSqmSqY = AClass.ConvertsqmTosqyrds(userInputSqmSqY);
                                AClass.toEntry(userPickToSqmSqY, resultSqmSqY);
                                break;
                        }
                        break;

                    case 2: // Square Foot
                        string userPickFromSqFt = (AClass.getList())[1];
                        conversionTo = AClass.conversionTo(userPickFromSqFt);

                        switch (conversionTo)
                        {
                            case 1: // Square Foot to Square Meter
                                Console.Clear();
                                string userPickToSqFtSqm = (AClass.getList())[0];
                                double userInputSqFtSqm = AClass.fromEntry(userPickFromSqFt);
                                double resultSqFtSqm = AClass.ConvertsqftTosqm(userInputSqFtSqm);
                                AClass.toEntry(userPickToSqFtSqm, resultSqFtSqm);
                                break;

                            case 2: // Square Foot to Hectares
                                Console.Clear();
                                string userPickToSqFtH= (AClass.getList())[1];
                                double userInputSqFtH= AClass.fromEntry(userPickFromSqFt);
                                double resultSqFtH = AClass.Convertsqfttohectar(userInputSqFtH);
                                AClass.toEntry(userPickToSqFtH, resultSqFtH);
                                break;
                            case 3: // Square Foot to Square Yards
                                Console.Clear();
                                string userPickToSqFtSqY= (AClass.getList())[1];
                                double userInputSqFtSqY= AClass.fromEntry(userPickFromSqFt);
                                double resultSqFtSqY = AClass.ConvertsqftTosqyrds(userInputSqFtSqY);
                                AClass.toEntry(userPickToSqFtSqY, resultSqFtSqY);
                                break;
                        }
                        break;

                    case 3: // Hectares
                        string userPickFromH = (AClass.getList())[2];
                        conversionTo = AClass.conversionTo(userPickFromH);

                        switch (conversionTo)
                        {
                            case 1: // Hectares to Square Foot
                                Console.Clear();
                                string userPickToHSqFt = (AClass.getList())[0];
                                double userInputHSqFt = AClass.fromEntry(userPickFromH);
                                double resultHSqFt= AClass.ConverthectarTosqft(userInputHSqFt);
                                AClass.toEntry(userPickToHSqFt, resultHSqFt);
                                break;

                            case 2: // Hectares to Square Meters
                                Console.Clear();
                                string userPickToHSqm = (AClass.getList())[1];
                                double userInputHSqm = AClass.fromEntry(userPickFromH);
                                double resultHSqm  = AClass.ConverthectarTosqm(userInputHSqm);
                                AClass.toEntry(userPickToHSqm , resultHSqm);
                                break;
                            case 3: // Hectares to Square Yards
                                Console.Clear();
                                string userPickToHSqY = (AClass.getList())[2];
                                double userInputHSqY = AClass.fromEntry(userPickFromH);
                                double resultHSqY  = AClass.ConverthectarTosqyrds(userInputHSqY);
                                AClass.toEntry(userPickToHSqY , resultHSqY);
                                break;
                        }
                        break;

                        case 4: // Square Yards
                        string userPickFromSqY = (AClass.getList())[3];
                        conversionTo = AClass.conversionTo(userPickFromSqY);

                        switch (conversionTo)
                        {
                            case 1: // Square Yards to Square Foot
                                Console.Clear();
                                string userPickToSqYSqFt = (AClass.getList())[0];
                                double userInputSqYSqFt = AClass.fromEntry(userPickFromSqY);
                                double resultSqYSqFt= AClass.ConvertsqyrdsTosqft(userInputSqYSqFt);
                                AClass.toEntry(userPickToSqYSqFt, resultSqYSqFt);
                                break;

                            case 2: // Square Yards to Square Meter
                                Console.Clear();
                                string userPickToSqYSqM = (AClass.getList())[1];
                                double userInputSqYSqM = AClass.fromEntry(userPickFromSqY);
                                double resultSqYSqM = AClass.ConvertsqyrdsTosqm(userInputSqYSqM);
                                AClass.toEntry(userPickToSqYSqM , resultSqYSqM);
                                break;

                            case 3: // Square Yards to Hectar
                                Console.Clear();
                                string userPickToSqYH = (AClass.getList())[2];
                                double userInputSqYH = AClass.fromEntry(userPickFromSqY);
                                double resultSqYH = AClass.ConvertsqyrdsTohectar(userInputSqYH);
                                AClass.toEntry(userPickToSqYH, resultSqYH);
                                break;
                        }
                        break;
                }
            }
            
            else if (userChoice == 6)
            {
                Console.Clear();
                Console.WriteLine($"Previous Result: {PreviousResult}");
                Arithmetic ArithClass = new Arithmetic();
                int optionSelect = (ArithClass.getUserChoice());
                double answer = ArithClass.Calculate(optionSelect);
                PreviousResult = answer;
                ArithClass.DisplayResult(optionSelect, answer);
            }

            else if (userChoice == 7)
            {
                Console.Clear();
                Forexechange ForexClass = new Forexechange();
                Console.WriteLine("Please use the code. ex: US Dollars = USD");
                Console.Write("Convert From: ");
                string userDefinedFrom = Console.ReadLine();
                Console.Write("Amount: ");
                string _amount = Console.ReadLine();
                double amount = double.Parse(_amount);
                ForexClass.setAmount(amount);
                Console.Write("Convert To: ");
                string userDefinedTo = Console.ReadLine();
                ForexClass.GetValues(userDefinedFrom, userDefinedTo);
                do
                {
                    Console.Write("-");
                    Console.Write("\b \b");
                    Console.Write("+");
                    Console.Write("\b \b");
                }
                while (!(ForexClass.getStatusResult()));
                if (ForexClass.getStatusResult())
                {
                    Console.ReadLine();
                }
            }

            else if (userChoice == 8)
            {
                startProgram = 0;
            }

            else
            {
                startProgram = 1;
            }
            }

            else
            {
                Console.WriteLine("Please enter a number");
                startProgram = 1;
            }
            
        }
        
    }
}
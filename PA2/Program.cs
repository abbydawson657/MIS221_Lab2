//Provide user with three menu option
//Vacation Planner
System.Console.WriteLine("Congratulations! You are the winner of our vacation getaway! \n");
System.Console.WriteLine("To figure out the best location to send you, there are a few questions.");

int prefTemp;
System.Console.WriteLine("What is your preferred temperature in Farenheit?");
prefTemp =int.Parse(Console.ReadLine());

while(prefTemp<=65){
    System.Console.WriteLine("Do you prefer 1. culture sightseeing or 2. landscape sightseeing?");
    int landscape = int.Parse(Console.ReadLine());
    if(landscape == 1){
            System.Console.WriteLine("Are you comfortable with a country that does not speak English?");
            string language = Console.ReadLine();

            if(language == "Yes"){
            System.Console.WriteLine("London has been chosen as your vacation spot!");
            break;
            }

                  else{
                    System.Console.WriteLine("Canada has been chosen as your vacation spot!");
                }
    }
    else{
        System.Console.WriteLine("Canada has been chosen as your vacation spot!");
    }

}
while(prefTemp>65) {  
    System.Console.WriteLine("Are you interested in learning about new cultures");
    string culture = Console.ReadLine();

        if(culture=="Yes"){
            System.Console.WriteLine("India has been chosen as your vacation");
        }
        else{
            System.Console.WriteLine("Switzerland has been chosen as your vacation!");
        }
        break;
}
System.Console.WriteLine("Use the budget calculator below to see how much spending money you will have for your trip!");

System.Console.WriteLine("Please Select an Option: \n 1. Budget Calculator \n 2. Currency Converter \n 3. Exit");
int customerSelect = int.Parse(Console.ReadLine());

    while(customerSelect == 1 || customerSelect == 2) {
    
    double totalSpending = 0;
    if(customerSelect == 1){
    //perform budget calculator
        System.Console.WriteLine("Please enter your overall monthly income: ");
        double income = int.Parse(Console.ReadLine());
        double budgetAmount;
        double savings = getSavings(ref income); 
        getSavings(ref income);

        //savings
        static double getSavings(ref double income){
            double savingsPercent = .2;
            double savingsAmount = income * savingsPercent;
            return savingsAmount;
        }

    budgetAmount = income - savings;

        double housing = GetHousing(ref budgetAmount);
        double food = GetFood(ref budgetAmount);
        double transportation = GetTrans(ref budgetAmount);
        double personal = GetPerson(ref budgetAmount);
        double utilites = GetUtilities(ref budgetAmount);
        double clothing = GetClothing(ref budgetAmount);

        //Housing Budget
        static double GetHousing(ref double budgetAmount){
            double houseRate = .25;
            double houseBudget = budgetAmount * houseRate;
            System.Console.WriteLine("The amount available to spend on housing is $" + houseBudget);
            System.Console.WriteLine("How much was spent on housing?");
            double houseSpent = int.Parse(Console.ReadLine());
            double houseTotal;
            
            houseTotal = houseBudget - houseSpent;

                if (houseSpent <= houseBudget){
                    System.Console.WriteLine("The amount remaining for housing is $" + houseTotal);
                    
                }
                    else {
                        System.Console.WriteLine("The housing budget was gone over $" + houseTotal);
                    }
                return houseTotal;
        }

        //Food Budget
        static double GetFood(ref double budgetAmount){
            double foodRate = .16;
            double foodBudget = budgetAmount * foodRate;
            System.Console.WriteLine("The amount available to spend on food is $" + foodBudget);
            System.Console.WriteLine("How much was spent on food?");
            double foodSpent = int.Parse(Console.ReadLine());
            double foodTotal;
            foodTotal = foodBudget - foodSpent;
                if (foodSpent <= foodBudget) {
                    System.Console.WriteLine("The amount remaining to spend on food is $" + foodTotal);
                }
                 else {
                        System.Console.WriteLine("The food budget was gone over $" + foodTotal);
                    }
                return foodTotal;
        }

        //Transportation Budget
        static double GetTrans (ref double budgetAmount){
            double transRate = .15;
            double transBudget = budgetAmount * transRate;
            System.Console.WriteLine("The amount available to spend on transportation is $" + transBudget);
            System.Console.WriteLine("How much was spent on transportation?");
            double transSpent = int.Parse(Console.ReadLine());
            double transTotal;
            transTotal = transBudget - transSpent;
                if (transSpent <= transBudget){
                    System.Console.WriteLine("The amount remaining to on spend transportation is $" + transTotal);
                }
                    else {
                        System.Console.WriteLine("The transportation was gone over $" + transTotal);
                    }
            return transTotal;
        }

        //Personal/Electronics Budget
        static double GetPerson (ref double budgetAmount){
            double personRate = .25;
            double personBudget = personRate * budgetAmount;
            System.Console.WriteLine("The amount available to spend on personal/electronics is $" + personBudget);
            System.Console.WriteLine("How much was spent on electronics/personal?");
            double overallPersonal = int.Parse(Console.ReadLine());
            System.Console.WriteLine("How many members are in your family?");
            double members = int.Parse(System.Console.ReadLine());
            //clarification if personal and electronics are one or seperate
            double personSpent = overallPersonal / members; 
            double personTotal;
            personTotal = personBudget - personSpent;

                if(personSpent <= personBudget){
                    System.Console.WriteLine("The amount remaining to spend on electronics/personal is $" + personTotal);
                }
                    else {
                        System.Console.WriteLine("The personal/electronic budget was gone over $" + personTotal);
                    }
                return personTotal;
        }

        //Utilities Budget
        static double GetUtilities(ref double budgetAmount){
            double utilitesRate = .11;
            double utilitesBudget = budgetAmount * utilitesRate;
            System.Console.WriteLine("The amount available to spend on utilities is $" + utilitesBudget);
            System.Console.WriteLine("How much was spent on utilities?");
            double utilitiesSpent = int.Parse(Console.ReadLine());
            double utilitesTotal;
            utilitesTotal = utilitesBudget - utilitiesSpent;
             if (utilitesBudget <= utilitiesSpent){
                    System.Console.WriteLine("The amount remaining to on spend utilities is $" + utilitesTotal);
                }

                    else {
                        System.Console.WriteLine("The transportation was gone over $" + utilitesTotal);
        }
        return utilitesTotal;
        }

        //Clothing Budget
        static double GetClothing(ref double budgetAmount){
            double clothesRate = .08;
            double clothesAmount = budgetAmount * clothesRate;
           System.Console.WriteLine("The amount available to spend on clothing is $" + clothesAmount);
            System.Console.WriteLine("How much was spent on clothing?");
            double clothingSpent = int.Parse(Console.ReadLine());
            double clothingTotal;
            clothingTotal = clothesAmount - clothingSpent;
             if (clothesAmount <= clothingSpent){
                    System.Console.WriteLine("The amount remaining to on spend utilities is $" + clothingTotal);
                }

                    else {
                        System.Console.WriteLine("The transportation was gone over $" + clothingTotal);
        }
        return clothingTotal;
        }
        
        totalSpending = food + transportation + personal + utilites + clothing + savings;
        System.Console.WriteLine("The amount to spend on vacation is $" +totalSpending);

        break;
     }


//Currency Converter
else if (customerSelect == 2){
double firstCurrency = 0;
double secondCurrency = 0;
double twoCurrency = 0;

System.Console.WriteLine("Select the currency for the country you are traveling from and the country you are going to!");
System.Console.WriteLine("Enter the amount to be converted: ");
double initialAmount = int.Parse(Console.ReadLine());
System.Console.WriteLine("What currency is your money currently in? \n1. US Dollar \n2. British Pound \n3. Swiss Franc \n4. Indian Rupee \n5. Canadian Dollar");
double beginCurrency = int.Parse(Console.ReadLine());

GetFirstCurrency(beginCurrency,firstCurrency);
GetSecondCurrency(twoCurrency, secondCurrency);

static double GetFirstCurrency(double beginCurrency, double firstCurrency){

    if(beginCurrency == 1) {
        firstCurrency = 1;
        System.Console.WriteLine("The beginning currency is in US Dollar");
    }
        if (beginCurrency==2){
            firstCurrency = .863;
            System.Console.WriteLine("The beginning currency is in British Pound");
        }
            if(beginCurrency == 3){
                firstCurrency = .980;
                System.Console.WriteLine("The beginning currency is in Swiss Franc");
            }

                if(beginCurrency == 4){
                    firstCurrency = 79.580;
                    System.Console.WriteLine("The beginning currency is in Indian Rupee");
                }

                    if(beginCurrency == 5){
                        firstCurrency = 1.315;
                       System.Console.WriteLine("The beginning currency is in Canadian Dollar");
                    }

        return firstCurrency;
}
System.Console.WriteLine("What currency would you like to convert to? \n1. US Dollar \n2. British Pound \n3. Swiss Franc \n4. Indian Rupee \n5. Canadian Dollar");
twoCurrency = int.Parse(Console.ReadLine());
GetSecondCurrency(twoCurrency, secondCurrency);
static double GetSecondCurrency(double twoCurrency, double secondCurrency){
    if(twoCurrency == 1){
        secondCurrency = 1;
        System.Console.WriteLine("The ending currency is in US Dollar");
    }
        if(twoCurrency==2){
            secondCurrency = .863;
            System.Console.WriteLine("The ending currency is in British Pound");
        }
            if(twoCurrency==3){
                secondCurrency = .980;
                System.Console.WriteLine("The ending currency is in Swiss Franc");
            }
                if(twoCurrency==4){
                    secondCurrency=79.580;
                    System.Console.WriteLine("The ending currency is in Indian Rupee");
                }
                    if(twoCurrency==5){
                        secondCurrency=1.315;
                        System.Console.WriteLine("The ending currency is in Canadian Dollar");
                    }
        
        return twoCurrency;
}

double newAmount;
newAmount = (GetFirstCurrency(beginCurrency, firstCurrency) * GetSecondCurrency(twoCurrency, secondCurrency)) * initialAmount;
System.Console.WriteLine("The amount needed to be converted is " + initialAmount);
System.Console.WriteLine("The new converted value is " + newAmount);
 }
    }

if(customerSelect==3){
System.Console.WriteLine("Exit");
    }

    else{
         System.Console.WriteLine("Invalvid selection.");
    }



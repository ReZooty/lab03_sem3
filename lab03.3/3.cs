namespace Currency
{
    class Currency
    {
        public double Value { get; set; }
    }

    class CurrencyRub : Currency
    {
        public static implicit operator CurrencyRub(double num)
        {
            return new CurrencyRub { Value = num };
        }

        public static explicit operator double(CurrencyRub cur)
        {
            return cur.Value;
        }
    }

    class CurrencyUsd : Currency
    {
        public static implicit operator CurrencyUsd(double num)
        {
            return new CurrencyUsd { Value = num };
        }

        public static explicit operator double(CurrencyUsd cur)
        {
            return cur.Value;
        }
    }

    class CurrencyEur : Currency
    {
        public static implicit operator CurrencyEur(double num)
        {
            return new CurrencyEur { Value = num };
        }

        public static explicit operator double(CurrencyEur cur)
        {
            return cur.Value;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter USD to RUB currency: ");
            double UsdToRub = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter EUR to RUB currency: ");
            double EurToRub = Convert.ToDouble(Console.ReadLine());
            CurrencyUsd usd = new CurrencyUsd { Value = 1200 };
            CurrencyRub rub1 = ((double)usd * UsdToRub);
            Console.WriteLine($"Convert {usd.Value} USD to RUB: {rub1.Value}");
            CurrencyEur eur1 = ((double)rub1 / EurToRub);
            Console.WriteLine($"Convert {usd.Value} USD to EUR: {eur1.Value}");

            CurrencyEur eur = new CurrencyEur { Value = 250 };
            CurrencyRub rub2 = ((double)eur * EurToRub);
            Console.WriteLine($"Convert {eur.Value} EUR to RUB: {rub2.Value}");
            CurrencyUsd usd2 = (double)eur * EurToRub / UsdToRub;
            Console.WriteLine($"Convert {eur.Value} EUR to USD: {usd2.Value}"); ;
        }
    }
}
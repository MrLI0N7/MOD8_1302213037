using jurnalmod8_1302213037;

internal class Program
{
    private static void Main(string[] args)
    {
        AppConfig appConfig = new AppConfig();
        try
        {
            appConfig.readConfig();
        }
        catch
        {
            appConfig.defaultConfig();
            appConfig.writeConfig();
            appConfig.readConfig();
        }

        if (appConfig.bankTFconfig.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer: ");
        }else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfet: ");
        }
        string inputAngka = Console.ReadLine();
        int angka = int.Parse(inputAngka);
        if(angka <= appConfig.bankTFconfig.transfer.threshold)
        {
            Console.WriteLine(appConfig.bankTFconfig.transfer.low_fee);
            int total = appConfig.bankTFconfig.transfer.low_fee + angka;
            if (appConfig.bankTFconfig.lang == "en")
            {
                Console.WriteLine("Total amount = "+total);
            }
            else
            {
                Console.WriteLine("Total biaya = " + total);
            }
            
        } else
        {
            Console.WriteLine(appConfig.bankTFconfig.transfer.high_fee);
            int total = appConfig.bankTFconfig.transfer.high_fee + angka;
            if (appConfig.bankTFconfig.lang == "en")
            {
                Console.WriteLine("Total amount = " + total);
            }
            else
            {
                Console.WriteLine("Total biaya = " + total);
            }
            
        }
        for (int i = 0; i < appConfig.bankTFconfig.method.Count; i++)
        {
            Console.WriteLine(appConfig.bankTFconfig.method[i]);
        }
        string input = Console.ReadLine();

        Console.Write("Please type "+ appConfig.bankTFconfig.confirmation.en +" to confirm the transaction: ");
        string confirm = Console.ReadLine();
        if (!appConfig.bankTFconfig.method.Contains(input) && confirm != appConfig.bankTFconfig.confirmation.en)
        {
            Console.WriteLine("Transfer is cancelled");
            return;
        }
        Console.WriteLine("Transfer is completed");
        return;




    }
}
namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //overideIntfloat overideIntfloat = new overideIntfloat();
            //overideIntfloat.Twoadd(10, 11);
            //overideIntfloat.Twoadd(10.0f, 11.0f);


            //areaRecSquare areaRecSquare = new areaRecSquare();
            //areaRecSquare.area(3);
            //areaRecSquare.area(2, 4);


            //SBI sBI = new SBI();
            //sBI.calculateInterest();
            //ICIC icic = new ICIC();
            //icic.calculateInterest();
            //HDFC  hDFC = new HDFC();    
            //hDFC.calculateInterest();
            //RBI rBI = new RBI();    
            //rBI.calculateInterest();

            //Hospital h = new Hospital();
            //h.HospitalDetails();
            //Apollo a = new Apollo();
            //a.HospitalDetails();
            //Wockhardt w = new Wockhardt();
            //w.HospitalDetails();
            //Gokul_Superspeciality g = new Gokul_Superspeciality();
            //g.HospitalDetails();

            //Area area = new Area();
            //area.area1(5);
            //area.area1(5, 2);
            //area.area1(5.5);

            BankAccount account = new BankAccount(100.2,"drashti");
            account.Deposite("drashti", 100);
            account.Withdrow("drashti", 100);
            account.Deposite(22.22);
            account.Withdrow( 22.22);



        }
    }
}

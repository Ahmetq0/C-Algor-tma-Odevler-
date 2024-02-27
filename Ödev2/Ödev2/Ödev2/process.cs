namespace Ödev2
{
    public static class process
    {
        public static int process1()
        {
            int x = Transactions.x_numaber();
            int y = Transactions.y_number();
            int z = Transactions.z_number();

            int process1 = (x + y) * z;
            Console.WriteLine("1.İşlemin sonucu:"+process1);
            
            
            int process2 = x * y + y * z;
            Console.WriteLine("2.İşlem sonucu:"+process2);
            return process1 & process2;
        }

        
    }
}
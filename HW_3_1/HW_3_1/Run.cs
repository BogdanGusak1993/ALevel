namespace HW_3_1
{
    public class Run
    {
        public void Start() 
        {
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            Console.WriteLine(test.Count);
        }  
    }
}

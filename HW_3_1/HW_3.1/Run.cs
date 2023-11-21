namespace HW_3_1
{
    public class Run
    {
        public void Start() 
        {
            var test = new CustomList<string>();
            //Chek method Add();
            test.Add("1");
            test.Add("2");
            test.Add("3");

            //Showing Count aftter adding items, and all items in my CustomList<T>
            Console.WriteLine(test.Count);
            test.ShowAsString();

            //Chek Enumerabel(forech)
            foreach (var item in test)
            {
                Console.WriteLine(item.ToString());
            }

            //Chek SetDefaultAt() method  
            test.SetDefaultAt(0);
            test.SetDefaultAt(3);

            //Showing Count and my CustomList<T> after all manipulatins 
            test.ShowAsString();
            Console.WriteLine(test.Count);
        }  
    }
}

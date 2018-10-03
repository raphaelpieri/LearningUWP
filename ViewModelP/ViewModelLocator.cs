namespace ViewModelP
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {

        }

        private static TrucksVM trucksVM;

        public static TrucksVM TrucksVM
        {
            get
            {
                if(trucksVM == null)
                {
                    trucksVM = new TrucksVM();
                }
                return trucksVM;
            }
        }
    }
}

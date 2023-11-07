namespace ClassLib
{
    public class Class1
    {
        public void Set(int x)
        {
            if (NumeberHelper.IsPositive(x))
            {
                Console.WriteLine("this is a positive NUmber");
            }
        }
    }



    public static class NumeberHelper
    {
        public static bool IsPositive( int input)
        {
            return input > 0;
        }
    }

    public class LoanReqest 
    {
        public loenRequerstEnum State { get; set; }
        public long Amounte { get; set; }
        public TimeSpan  LoadDuration { get; set; }

        public void updatae(long amounte, TimeSpan loadDuration)
        {
            if (State == loenRequerstEnum.Draft)
            {
                this.Amounte= amounte;
                this.LoadDuration= loadDuration;
            }
            else
            {
                throw new Exception();
            }

            ///Behavior of and that state 
        }

        public void Accept()
        {
            if (State == loenRequerstEnum.InProgress)
                this.State = loenRequerstEnum.Accepeted;
            else
                throw new Exception(); 

        }
    }




    public enum loenRequerstEnum
    {
        Draft, //پیش نویس 
        Rejected,
        Accepeted,
        InProgress
    }

}
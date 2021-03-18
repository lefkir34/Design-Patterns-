using System.Threading;
namespace Singleton_Pattern
{
    public class Counter
    {
        

        private static Counter Instance  =null;
        private static object LockObj = new object();
        private Counter()
        {
            
        }


        public static Counter GetInstance (){

            if(Instance == null){
            lock (LockObj)
            {
                 Thread.Sleep(2000);
                  if (Instance == null){ return new Counter();}
            }
          }
            return Instance ;
        }
        public  int count = 0 ;
        public  void AddOne(){
            count ++ ;
        }
    }
}
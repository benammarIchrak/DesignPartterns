namespace DesignPartterns;

public class SemaphoreTest
{
    private static Semaphore? _semaphore = null;

        public void Demo()
        {
            try
            {
                //Try to Open the Semaphore if Exists, if not throw an exception
                _semaphore = Semaphore.OpenExisting("SemaphoreTest");
            }
            catch(Exception Ex)
            {
                //If Semaphore not Exists, create a semaphore instance
                //Here Maximum 2 external threads can access the code at the same time
                _semaphore = new Semaphore(2, 2, "SemaphoreDemo");
            }

            Console.WriteLine("External Thread Trying to Acquiring");
            _semaphore.WaitOne();
            //This section can be access by maximum two external threads: Start
            Console.WriteLine("External Thread Acquired");
            Console.ReadKey();
            //This section can be access by maximum two external threads: End
            _semaphore.Release();
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{//Hata yakalama
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }



            //Method
            HandleException(() => { Find(); });
            
           

        }
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception);
                throw;
            }
        }
        private static void Find()
        {
            List<String> students = new List<String> { "Elon", "Gates", "Bezos" };
            if (students.Contains("Elon"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionIntro()
        {
            //Çalıştıracağımız kod'u try bloğunun içerisine yazıyoruz.
            try
            {
                string[] students = new string[3] { "Fayik", "Füsun", "Ecem" };
                students[1] = "Ahmet";
                students[3] = "Cemre"; //Burası hatalı olduğu için ve array dışarısına taşacağı için catch bloğuna geçip hata fırlatacaktır.
                Console.WriteLine(students[0]);
                //Olurda burada yazılan kodlarda bir hata yakalanırsa kod burayı bırakıp bir aşağı catch bloğuna geçiş yapacaktır.
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }


            catch (IndexOutOfRangeException ex)//Buradaki catch bloğu eğer önemli birtakım hatalrın peşinden koşuyorsak onu getirip öncellikle yerine yazmamız gerekecektir.Ve hatanın ne olduğuu message şeklinde yazdıracağızdır.
            //Eğer tahmin edilen hata ekranda yazdırılacaksa diğer catch bloğuna geçiş yapmaz eğer hatamız bu bloktakine uyum sağlamazsa eğer varsa diğer catch bloğundaki değer takip bölümüne geçiş yapacaktır.
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);//Normalde program hatayı ne şekilde derlemişse onu kullanıcıya yazdıracktır.
                //Ancak bu kesinlikle tavsiye edilmemektedir.Çünkü kullanıcıya verilmemesi gereken bilgileri derleyip verebilirçVe bu da birtakım güvenlik zaafiyetlerinin oluşmasına neden olabilir.
                Console.WriteLine("Girilen bilgilerin kontrolünü tekrar gerçekleştiriniz.");
            }
        }
    }
}

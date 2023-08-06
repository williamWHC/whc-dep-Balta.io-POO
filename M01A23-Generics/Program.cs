using M01A23_Generics.Service;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var person = new Person();
        var payment = new Payment();
        var subscription = new Subscription();

        DataContext dBContext = new DataContext<IPerson, Payment, Subscription>;
        dBContext.Save(person);
        dBContext.Save(payment);
        dBContext.Save(subscription)
    }

    public class DataContext<P, PA, S>
        where P : IPerson where PA : Payment where S : Subscription
    {
        public void Save(P entity)
        {

        }

        public void Save(PA entity)
        {

        }

        public void Save(S entity)
        {

        }
    }

    public class Person() : IPerson
    {

    }

    public class Payment()
    {

    }

    public class Subscription()
    {

    }

    public interface IPerson()
    {

    }

}
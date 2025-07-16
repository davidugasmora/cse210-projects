using System;

class Program
{
    static void Main(string[] args)
    {
        Address myAddress = new Address("123 Main ST", "Nowhere", "ID", "USA");

        EventLecture myLecture = new EventLecture("My lecture", "This is a description for a lecture", "August 24th", "2:40pm", myAddress, "Marco Salazar", 24);
        myLecture.DisplayStandardDetails();
        myLecture.DisplayFullDetails();
        myLecture.DisplayShortDetails();

        EventReception myReception = new EventReception("My Reception", "This is a description for a reception", "November 1st", "9:00pm", myAddress, "myEmail@gmail.com");
        myReception.DisplayStandardDetails();
        myReception.DisplayFullDetails();
        myReception.DisplayShortDetails();

        EventOutdoorGathering myOutdoorGathering = new EventOutdoorGathering("My outdoor gathering", "This is a description for an outdoor gathering", "March 11th", "4:30pm", myAddress, "Summer");
        myOutdoorGathering.DisplayStandardDetails();
        myOutdoorGathering.DisplayFullDetails();
        myOutdoorGathering.DisplayShortDetails();

    }
}
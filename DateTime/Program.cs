DateTime date1 = new DateTime(2023, 11, 19); // il ay ve gun sirasi ile yazilir
Console.WriteLine(date1.ToString()); //baxdigim yerde "ToString" yazmagimi deyirdim amma onsuz yoxladim yene isleyir
Console.Write(DateTime.MinValue); //mumkun minimum tarix, MaxValue yazsaq mumkun maks tarix yazilacaq
DateTime today = DateTime.Now;// hazirki tarixi qeyd etmek

Console.WriteLine(date1 = today.AddDays(1)); //tarixe gun elave etmek
System.TimeSpan duration = new System.TimeSpan(30, 0, 0, 0); //timespan yaratmaq ucun, vaxt intervallari ucun istifade olunur.


string dateString = "Sun Nov 19, 2023"; // string formasinda date
DateTime dateTime0 = DateTime.Parse(dateString); // hemin stringi esl date formasina Parse etmek

System.DateTime date3 = new System.DateTime(2020, 11, 19);
System.DateTime date4 = new System.DateTime(2023, 2, 1);
System.TimeSpan diff1 = date4.Subtract(date3); //iki date arasindaki ferqi tapmaq
Console.WriteLine(diff1); //804 gun

DateTime dt = new DateTime(2023, 11, 19);
bool isEqual = (dt.DayOfWeek == DayOfWeek.Sunday); // heftenin gununu tapmaq ucun
Console.WriteLine(isEqual); // True
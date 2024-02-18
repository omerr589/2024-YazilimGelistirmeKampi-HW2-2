
using ReferenceTypes;

int sayi1 = 10;
int sayi2 = 20;

sayi1 = sayi2;

sayi2 = 100;

Console.WriteLine(sayi1);   // int değişkenler referans tipler olmadığından dolayı içinde değeri tutar.
                            // int, decimal float, enum, boolean veri tipleri value veri tipleridir. 

int[] sayilar1 = new int[] { 1, 2, 3 };
int[] sayilar2 = new int[] { 10, 20, 30 };

sayilar1 = sayilar2;

sayilar2[0] = 100;


Console.WriteLine(sayilar1[0]); // Diziler referans tipler olduğundan dolayı sonuç 100
                                // arrays, class, interfaces referance tiplerdir


Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "Ömer";
person2 = person1;

person1.FirstName = "Engin";

Console.WriteLine(person2.FirstName); // Engin

Customer customer = new Customer();
Employee employee = new Employee();

customer.FirstName = "Salih";
employee.FirstName = "Fatih";
customer.CreditCardNumber = "1231546";

Person person3 = customer;
Console.WriteLine(person3.FirstName); // Salih

Console.WriteLine(((Customer)person3).CreditCardNumber); // 1231546

PersonManager personManager = new PersonManager();

personManager.Add(person3);  // Salih
personManager.Add(customer); // Salih
personManager.Add(employee); // Fatih
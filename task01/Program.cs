// Задача 19
 int n,r,sum=0,temp;    
 Console.Write("Введите пятизначное число: ");   
 n = int.Parse(Console.ReadLine());  
 temp=n;      
 while(n>0)      
 {      
 r=n%10;      
 sum=(sum*10)+r;      
 n=n/10;      
 }      
 if(temp==sum)      
 Console.Write("Число является полиндромом.");      
 else      
 Console.Write("Число не является полиндромом.");     
    
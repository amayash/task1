import java.util.Scanner;
public class nomer2 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите первое число(максимум 5 разрядов):");
        int n1 = scanner.nextInt();
        if (n1>99999) System.out.println("Не подходит");
        System.out.print("Введите второе число:");
        int n2 = scanner.nextInt();
        if (n2>99999) System.out.println("Не подходит");
        System.out.print("Введите третье число:");
        int n3 = scanner.nextInt();
        if (n3>99999) System.out.println("Не подходит");

        int sum1=0;
        while(n1 != 0 && n1<=99999){
            //Суммирование цифр числа
            sum1 += (n1 % 10);
            n1/=10;
        }
        int sum2=0;
        while(n2 != 0 && n2<=99999){
            sum2 += (n2 % 10);
            n2/=10;
        }
        int sum3=0;
        while(n3 != 0 && n3<=99999){
            sum3 += (n3 % 10);
            n3/=10;
        }
        if ( (sum1+sum2+sum3)%(sum1-sum2)==0 )
            System.out.print("Делится");
        else System.out.print("Не делится");
    }
}
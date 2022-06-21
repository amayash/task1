import java.util.Scanner;
import java.math.BigInteger;
public class nomer32 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите число меньше 1001:");
        int n1 = scanner.nextInt();
        String chislo = Integer.toString(n1);
        BigInteger n = new BigInteger(chislo);
        BigInteger rez = new BigInteger(chislo);
        for (int i=1;i<n1;i++) {
            rez=rez.multiply(n);
        }
        System.out.println(n1 + "^" + n1 + "=" + rez);

        int help=0;

        int counter[] = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        BigInteger desyat = new BigInteger("10");

        while(!rez.equals(BigInteger.ZERO)){
            help=(rez.mod(desyat)).intValue();
            counter[help]+=1;
            rez=rez.divide(desyat);
        }
        System.out.println("Нулей - " + counter[0] + ", единиц - " + counter[1] + ", двоек - " + counter[2] + ", троек - " + counter[3] +
                ", четверок - " + counter[4] + ", пятерок - " + counter[5] + ", шестерок - " + counter[6] + ", семерок - " + counter[7] +
                ", восьмерок - " + counter[8] + ", девяток - " + counter[9]);

    }
}
 
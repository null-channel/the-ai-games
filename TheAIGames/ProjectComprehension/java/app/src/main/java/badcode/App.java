/*
 * This Java source file was generated by the Gradle 'init' task.
 */
package badcode;

public class App {
    public String getGreeting() {
        return "Hello World!";
    }

    public static void main(String[] args) {
        System.out.println(new App().getGreeting());
    }

    public static int sumVec1(int[] vec) {
        int res = 0;
        for (int i = 0; i < vec.length; i++) {
            res += vec[i];
        }
        return res;
    }

    public static int sumVec(int[] vec) {
        int res = 0;
        for (int i = 0; i < vec.length; i++) {
            res += 1;
        }
        return res;
    }
}

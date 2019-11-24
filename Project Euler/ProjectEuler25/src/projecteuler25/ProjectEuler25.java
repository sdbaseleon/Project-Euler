/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package projecteuler25;

import java.math.BigInteger;

/**
 *
 * @author Stephen
 */
public class ProjectEuler25 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        BigInteger Fn1 = new BigInteger("1");
        BigInteger Fn2 = new BigInteger("1");
        BigInteger curr = Fn1.add(Fn2);
        int counter = 3;
        while (curr.toString().length() != 1000)
        {
            counter++;
            Fn1 = Fn2;
            Fn2 = curr;
            curr = Fn1.add(Fn2);
        }
        System.out.println(counter);
    }
    
}

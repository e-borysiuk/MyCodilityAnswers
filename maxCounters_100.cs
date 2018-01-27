using System;

//refactorized - 100/100

class Solution {

    private int[] counters;
    private int maxCounter;
    private int lastUpdate;
    public int[] solution(int N, int[] A) {
        if(A.Length == 0 || A == null) return new int[1];
        
        counters = new int [N];
        int condition = N + 1;

        foreach(int val in A)
        {
            if(val >= 1 && val <= N) 
            {
                increaseCounter(val);
            }
            else if(val == condition)
            {
                lastUpdate = maxCounter;
            } 
               
        }
        for (int i = 0; i < counters.Length; i++)
        {
            if(counters[i] < lastUpdate) counters[i] = lastUpdate;
        }

        return counters;
    }

    private void increaseCounter(int i)
    {
        i--;
        if(counters[i] < lastUpdate) counters[i] = lastUpdate + 1;
        else counters[i]++; 
        if(counters[i] > maxCounter) maxCounter = counters[i];
    }
}
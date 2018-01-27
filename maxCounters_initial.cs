using System;

//60% performance because it's O(N * M) because maxCounters iterates through whole array every time
//There can be some smaller tweaks like adding N+1 to variable so CPU won't have to do addition every time it checks if statement. 

class Solution {
    private int[] counters;
    private int maxCounter;
    public int[] solution(int N, int[] A) {
        if(A.Length == 0 || A == null) return new int[1];
        counters = new int [N];
        foreach(int val in A)
        {
            if(val >= 1 && val <= N) increaseCounter(val);
            else if(val == N + 1) maxCounters();
        }
        return counters;
    }
    private void increaseCounter(int i)
    {
        if(counters[i - 1] + 1 > maxCounter) maxCounter = counters[i - 1] + 1;
        counters[i - 1]++;   
    }
    private void maxCounters()
    {
        for(int i = 0; i < counters.Length; i++)
        {
            counters[i] = maxCounter;   
        }
    }
}
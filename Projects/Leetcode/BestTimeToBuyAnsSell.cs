﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*
     * Say you have an array for which the ith element is the price of a given stock on day i.
     * 
     * If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the stock), design an algorithm to find the maximum profit.
     */
    public class BestTimeToBuyAnsSell
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1) return 0;
            int top = prices[0];
            int bottom = prices[0];
            int maxProfit = 0;
            int newBottom = prices[0];
            for(int i = 0; i < prices.Length; i++)
            {
                if(prices[i] > top)
                {
                    top = prices[i];
                    maxProfit = top - bottom;
                }
                else if(prices[i] < newBottom )
                {
                    newBottom = prices[i];
                }
                if(maxProfit < prices[i] - newBottom)
                {
                    top = prices[i];
                    bottom = newBottom;
                    maxProfit = top - bottom;
                }
            }
            return maxProfit;
        }
    }

    /*
     * Say you have an array for which the ith element is the price of a given stock on day i.

     * Design an algorithm to find the maximum profit. You may complete as many transactions as you like (ie, 
     * buy one and sell one share of the stock multiple times). However, you may not engage in multiple transactions 
     * at the same time (ie, you must sell the stock before you buy again).
     */
    public class BestTimeToBuyAndSellII
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1) return 0;
            int profit = 0;
            for(int i= 1; i < prices.Length; i++)
            {
                if(prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }
            return profit;
        }
    }

    /*
     * Say you have an array for which the ith element is the price of a given stock on day i.

     * Design an algorithm to find the maximum profit. You may complete at most two transactions.
     * 
     * Note:
     * You may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
     */
    public class BestTimeToBuyAndSellIII
    {
        class Point
        {
            public int Price { get; set; }
            public int Index { get; set; }
        }

        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1) return 0;
            int[] maxFromHead = new int[prices.Length];
            int[] maxFromTail = new int[prices.Length];
            maxFromHead[0] = 0;
            int bottom = prices[0];
            int currentMax = 0;
            for(int i = 1; i < prices.Length; i++ )
            {
                bottom = Math.Min(prices[i], bottom);
                if (currentMax < prices[i] - bottom)
                {
                    currentMax = prices[i] - bottom;
                }
                maxFromHead[i] = currentMax;
            }
            int top = prices[prices.Length - 1];
            int maxProfit = maxFromHead[0] + maxFromHead[prices.Length - 1];
            currentMax = 0;
            for(int j = prices.Length - 2; j >= 0; j-- )
            {
                top = Math.Max(prices[j + 1], top);
                if(currentMax < top - prices[j])
                {
                    currentMax = top - prices[j];
                }
                if(maxProfit < maxFromHead[j] + currentMax)
                {
                    maxProfit = maxFromHead[j] + currentMax;
                }
            }
            return maxProfit;
        }
    }
}

using System;

namespace UtilizationChecks {
    //A new Amazon-developed scaling computing system checks its average utilization every second while it monitors.
    //It implements an autoscale policy to increase or reduce instances depending on the current load as described below.
    //Once an action of increasing or reducing the number of instances is performed, the system will stop monitoring for 10
    //seconds. During that time, the number of instances does not change.

    //• If the average utilization < 25%, then an action is instantiated to reduce the number of instances by half if the number
    //of instances is greater than 1 (take the ceiling if the number is not an integer). If the number of instances is 1, take no
    //action.
    //• If 25% <= average utilization <= 60%, take no action.
    //• If the average utilization > 60%, then an action is instantiated to double the number of instances if the doubled value
    //does not exceed 2 * 10^8. If the number of instances exceeds this limit upon doubling, take no action.

    //Given an array of integers that represent the average utilization at each second, determine the number of instances at the
    //end of the time frame.

    //Example
    //instances = 2
    //averageUtil = [25, 23, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 76, 80]    
    //Explanation:
    //• At second 1, the average utilization averageUtil[0] = 25 ≤ 25, take no action.
    //• At second 2, the average utilization averageUtil[1] = 23 < 25, reduce the number of instances by half 2/2 = 1.
    //• Since an action was taken, the system will stop checking for 10 seconds, from averageUtil[2] through averageUtil[11]    
    //• At second 13, at averageUtil[12] = 76 > 60, so the number of instances is doubled from 1 to 2.
    //• There are no more readings to consider and 2 is the final answer.

    //Returns:
    //int: an integer that represents the final number of instances running

    //Sample case 0
    //instances = 1
    //averageUtil[] = [5, 10, 80]    
    //Sample Output = 2
    //Explanation:
    //• At second 1, averageUtil[0] = 5 < 25. The number of instances is 1, so take no action.
    //• At second 2, averageUtil[1] = 10 < 25. The number of instances is 1, so take no action.
    //• At second 3, averageUtil[2] = 80 > 60. An action is instantiated to double the number of instances from 1 to 2.    
    //• There are no more readings to consider and 2 is the final answer.

    //Sample Case 1
    //instances = 5,
    //averageUtil[] = { 30, 5, 4, 8, 19, 89 }
    //Output: 3
    //Explanation:
    //• At second 1, 25 ≤ averageUtil[0] = 30 ≤ 60, so take no action.
    //• At second 2, averageUtil[1] = 5 < 25, so an action is instantiated to halve the number of instances to ceil(5/2) = 3.
    //• The system will stop checking for 10 seconds, so from averageUtil[2] through averageUtil[5] no actions will be taken.
    //There are no more readings to consider and 3 is the final answer.

    class Program {
        static void Main(string[] args) {
            Console.WriteLine(finalInstances(2, new int[] { 25, 23, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 76, 80 })); //Expected: 2
            Console.WriteLine(finalInstances(1, new int[] { 5, 10, 80 })); //Expected: 2
            Console.WriteLine(finalInstances(5, new int[] { 30, 5, 4, 8, 19, 89 })); //Expected: 3
        }

        public static int finalInstances(int instances, int[] averageUtil) {
            
            for (int i = 0; i < averageUtil.Length; i++) {
                if (typeof(int) != averageUtil[i].GetType()) {
                    return 0;
                }

                if (averageUtil[i] < 25 && instances > 1) {                    
                    instances = (int)Math.Ceiling(instances / 2.0); //instances = (int)Math.Ceiling((decimal)instances / 2);
                    i += 10;                     
                } else if (averageUtil[i] > 60 && instances < 100000000) {
                    instances = instances * 2;
                    i += 10;                    
                } else {
                    continue;
                }
            }

            return instances;
        }
    }
}

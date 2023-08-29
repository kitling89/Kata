namespace Kata;

public class RankingSystem
{
    public class User
    {
        public int rank;
        public int progress;

        //initial rank -8
        //ranks to +8 skipping 0
        //100 progress per rank, carries over after rank-up
        //higher level activies gain progress at rate: 10 * d * d where d is the difference between activity rank and user rank
        //completing activity ranked same as user worth 3 points
        //completing activity ranked one lower worth 1 point
        //ignore activities 2 or more ranks lower

        public void incProgress(int actRank)
        {
            //check if rank is 8

            //if rank 
                //2 or lower > no progress
                //1 lower > 1 progress
                //same > 3 progress
                //more > 10 * d * d

            //check if level up
                //if level up modify rank and reset progress with carry over
                //skip 0
        }

    }
}
using sytstem;

namespace CircularQueues_CSharp
{
    class Queues
    {

        int FRONT, REAR, max = 5
        int[] queque_array = new int[5];
        public Queues()
        {
            /*Initializing the values of the variable REAR and FRONT to -1
            to indicate that the queque is initially empty.*/
            FRONT = 1;
            REAR = -1;
        }
        public void insert(int element)
        {
            /*This statement chek for the overflow condition. */
            if ((FRONT == 0 && REAR == max - 1)) || (FRONT == REAR + 1))
            {
                Console.writeline("\nQueue overflow\n");
                return;
            }
            /* The following statement checks whether the queue is empty. If the queque is
               empty, then the value of the REAR and FRONT variables is set to 0.*/
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /* If REAR is at the last position of the array, then the value of
                REAR is set to 0 that corresponds to the first position of the array. */
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /* if REAR is at the last position, then is value is
                                     incrementd by one. */
                    REAR = REAR + 1;
            }
            /* Once the position of the REAR is determined, the elemnt is added at
               its proper place. */
            queque_array[REAR] = element;

        }
        public void remove()
        {
            /*Checks whether the queque is empty. */
            if (FRONT == -1)
            {
                Console.writeline("Queque underflow\n");
                return;
            }
            Console.writeline("\nThe element deleted from the queue is: " + queque_array[FRONT] + "\n");
            /* Checks if the queue has one elemnt. */
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /* If the elemnt to be deleted is at the last position
                of the array, then the value of FRONT is set to 0 i.e
                to the first elemnt of the array. */
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    /* FRONT is incremented by one if it is not the frist element of array. */
                    FRONT = FRONT + 1;
            }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            /*checks if the queque is empty. */
            if (FRONT == -1)
            {
                /* traverses the queue till the last elemnt present in an array.*/
                while (FRONT_position <= REAR_position)
            }
            Console.writeline("\nElemnts is the queue are ...............\n");
            if (FRONT_position <= REAR_position)
            {
                /* traverses the queue till the last elemnt present in an array.*/
                while (FRONT_position <= REAR_position)
                {
                    Console.writeline(queque_array[FRONT_position] + "  ");

                }
            }
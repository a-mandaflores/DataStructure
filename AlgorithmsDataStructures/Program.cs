//Arrays
//Arrays Insertions & Deletion

int[] intArray = new int[6];

int length = 0;

//Add in the end

for (int i = 0; i <  3; i++)
{
    intArray[length] = i + 1 ;
    length++;
}

//Add in the start

for( int i = 3 ; i >= 0; i--)
{
    intArray[i + 1] = intArray[i];
}

intArray[0] = 20 ;
length++;
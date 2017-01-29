/**
  * Created by ranji on 1/28/17.
  */
object CountBits {

  def numberOfOneBits(n:Int):Int = {
    var numberOfOnes = 0
    for(i <- 0 to 32){
      if (bitIsOne(n,i) == true) numberOfOnes = numberOfOnes+1
    }
    return numberOfOnes
  }

  def bitIsOne(n:Int,position:Int) : Boolean = (n&(1<<position))!=0

}

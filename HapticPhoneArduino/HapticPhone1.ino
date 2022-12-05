int i;
int intArray;
String activatedArray;
String s ="11100";

void setup() {
  // start serial port at 9600 bps:
  Serial.begin(115200);
  Serial.setTimeout(20);
  pinMode(1, OUTPUT); 
  pinMode(2, OUTPUT); 
  pinMode(3, OUTPUT); 
  pinMode(4, OUTPUT); 
  pinMode(5, OUTPUT); 
  pinMode(LED_BUILTIN,OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);
  digitalWrite(2, LOW);
  digitalWrite(3, LOW);
  digitalWrite(4, LOW);
  digitalWrite(5, LOW);
  digitalWrite(6, LOW);
  
}
void loop() {
  // if we get a valid byte, read analog ins:
  if (Serial.available() > 0) {
    // get incoming byte:
      activatedArray = Serial.readString();
      activatedArray.trim();
      // Serial.print(activatedArray[0]);
      // Serial.print(activatedArray[1]);
      // Serial.print(activatedArray[2]);
      // Serial.print(activatedArray[3]);
       //Serial.print(activatedArray);
       i =activatedArray.compareTo(s);
       Serial.print(i);
      //activate(activatedArray);

      if (activatedArray.compareTo(s) == 13)
      {
       //digitalWrite(2, HIGH);
          Serial.print(activatedArray[0]);
          Serial.print(activatedArray[1]);
          Serial.print(activatedArray[2]);
          Serial.print(activatedArray[3]);
          Serial.print(activatedArray[4]);
      }
      //Serial.print(activatedArray[4]);
      // else{digitalWrite(2, LOW);}

      // if (activatedArray[1] == "1")
      // {
      //   digitalWrite(3, HIGH);
      // }
      // else{digitalWrite(3, LOW);}

      // if (activatedArray[2] == "1")
      // {
      //   digitalWrite(4, HIGH);
      // }
      // else{digitalWrite(4, LOW);}

      // if (activatedArray[3] == "1")
      // {
      //   digitalWrite(5, HIGH);
      // }
      // else{digitalWrite(5, LOW);}

      // if (activatedArray[4] == "1")
      // {
      //   digitalWrite(6, HIGH);
      // }
      // else{digitalWrite(6, LOW);}
    
      // blink_it(1);

      // digitalWrite(2, HIGH);
      // delay(500);
      // digitalWrite(2, LOW);
      

    
  }
  delay(100);
  
}

// void activate(String hapticArray)
// {
//   if (hapticArray[0] == "1")
//   {
//     digitalWrite(2, HIGH);
//   }
//   else{digitalWrite(2, LOW);}

//   if (hapticArray[1] == "1")
//   {
//     digitalWrite(3, HIGH);
//   }
//   else{digitalWrite(3, LOW);}

//   if (hapticArray[2] == "1")
//   {
//     digitalWrite(4, HIGH);
//   }
//   else{digitalWrite(4, LOW);}

//   if (hapticArray[3] == "1")
//   {
//     digitalWrite(5, HIGH);
//   }
//   else{digitalWrite(5, LOW);}

//   if (hapticArray[4] == "1")
//   {
//     digitalWrite(6, HIGH);
//   }
//   else{digitalWrite(6, LOW);}

// }

// void blink_it(int the_count){
//   for (int ii=0;ii<the_count;ii++){

//      digitalWrite(2, HIGH);
//      delay(150);
//      digitalWrite(2, LOW);
//      delay(150);
//   }        
// }


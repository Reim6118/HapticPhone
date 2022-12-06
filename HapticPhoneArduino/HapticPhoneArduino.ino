int i;
int intArray;
String activatedArray;
// String s ="11100";
char zero ='0';
char one ='1';

void setup() {
  // start serial port at 9600 bps:
  Serial.begin(115200);
  Serial.setTimeout(20);
  pinMode(2, OUTPUT); 
  pinMode(3, OUTPUT); 
  pinMode(4, OUTPUT); 
  pinMode(5, OUTPUT); 
  pinMode(6, OUTPUT); 
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
      // Serial.print(activatedArray);
      // i =activatedArray.compareTo(s);
      // Serial.print(i);
      activate(activatedArray);

      // if (activatedArray.compareTo(s) == 0)
      // {
      //  //digitalWrite(2, HIGH);
      //     Serial.print(activatedArray[0]);
      //     Serial.print(activatedArray[1]);
      //     Serial.print(activatedArray[2]);
      //     Serial.print(activatedArray[3]);
      //     Serial.print(activatedArray[4]);
      // }
      

  
  }
  //delay(100);
  
}

void activate(String hapticArray)
{
  if (hapticArray[0] == one)
  {
    Serial.print("1");
    digitalWrite(2, HIGH);
    // delay(200);
    // digitalWrite(2,LOW);
  }
  else{Serial.print(0);digitalWrite(2, LOW);}

  if (hapticArray[1] == one)
  {
    Serial.print("1");
    digitalWrite(3, HIGH);
    // delay(200);
    // digitalWrite(3,LOW);
  }
  else{Serial.print(0);digitalWrite(3, LOW);}

  if (hapticArray[2] == one)
  {
    Serial.print("1");
    digitalWrite(4, HIGH);
    // delay(200);
    // digitalWrite(4,LOW);
  }
  else{Serial.print(0);digitalWrite(4, LOW);}

  if (hapticArray[3] == one)
  {
    Serial.print("1");
    digitalWrite(5, HIGH);
    // delay(200);
    // digitalWrite(5,LOW);
  }
  else{Serial.print(0);digitalWrite(5, LOW);}

  if (hapticArray[4] == one)
  {
    Serial.print("1");
    digitalWrite(6, HIGH);
    // delay(200);
    // digitalWrite(6,LOW);
  }
  else{Serial.print("in here");digitalWrite(6, LOW);}

}



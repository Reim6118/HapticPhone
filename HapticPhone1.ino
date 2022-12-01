int inByte;
void setup() {
  // start serial port at 9600 bps:
  Serial.begin(9600);
  pinMode(LED_BUILTIN, OUTPUT); 
  digitalWrite(LED_BUILTIN, LOW);
}
void loop() {
  // if we get a valid byte, read analog ins:
  if (Serial.available() > 0) {
    // get incoming byte:
    inByte = Serial.read();
    
      blink_it(1);
      //digitalWrite(LED_BUILTIN, HIGH);
    
  }
  
  delay(500);
}


void blink_it(int the_count){
  for (int ii=0;ii<the_count;ii++){

     digitalWrite(LED_BUILTIN, HIGH);
     delay(150);
     digitalWrite(LED_BUILTIN, LOW);
     delay(150);
  }        
}


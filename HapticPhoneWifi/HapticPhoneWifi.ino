#include <WiFi.h>

// Replace these with your WiFi network's SSID and password
// const char *ssid = "lalalalala";
// const char *password = "lalalala";
const char *ssid = "km13307-102";
const char *password = "e2p57ci1w";
char zero ='0';
char one ='1';
//char buffer[5];
String buffer;

// Create a server object
WiFiServer server(6118);  // Use port 23 for the server

void setup() {
  Serial.begin(115200);
  pinMode(16, OUTPUT); 
  pinMode(17, OUTPUT); 
  pinMode(18, OUTPUT); 
  pinMode(19, OUTPUT); 
  pinMode(21, OUTPUT); 
  digitalWrite(16, LOW);
  digitalWrite(17, LOW);
  digitalWrite(18, LOW);
  digitalWrite(19, LOW);
  digitalWrite(21, LOW);
  // Connect to WiFi network
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.println("Connecting to WiFi..");
  }
  Serial.println("Connected to the WiFi network");

  // Start the server
  server.begin();
  Serial.println("Server started");

  // Print the IP address
  Serial.println(WiFi.localIP());
}

void loop() {
  // Check if there are any new clients
  WiFiClient client = server.available();
  if (client) {
 
    client.setTimeout(20);
    while (client.connected()) {
 
      while (client.available()>0) {

        char c = client.read();
        buffer += c;
        if (buffer.length()==5)
          {activate(buffer);
          Serial.print("send to activate ="+buffer+"\n");
          buffer = "";}  
        
          
        
        //activate(c);
        //Serial.print("in while"+buffer);

        //Serial.write(c);
      }
 
      
    }
 
    client.stop();
    Serial.println("Client disconnected");
 
  }
}

void activate(String hapticArray)
{
  if (hapticArray[0] == one)
  {
    Serial.print("1");
    digitalWrite(16, HIGH);
    // delay(200);
    // digitalWrite(2,LOW);
  }
  else{Serial.print(0);digitalWrite(16, LOW);}

  if (hapticArray[1] == one)
  {
    Serial.print("1");
    digitalWrite(17, HIGH);
    // delay(200);
    // digitalWrite(3,LOW);
  }
  else{Serial.print(0);digitalWrite(17, LOW);}

  if (hapticArray[2] == one)
  {
    Serial.print("1");
    digitalWrite(18, HIGH);
    // delay(200);
    // digitalWrite(4,LOW);
  }
  else{Serial.print(0);digitalWrite(18, LOW);}

  if (hapticArray[3] == one)
  {
    Serial.print("1");
    digitalWrite(19, HIGH);
    // delay(200);
    // digitalWrite(5,LOW);
  }
  else{Serial.print(0);digitalWrite(19, LOW);}

  if (hapticArray[4] == one)
  {
    Serial.print("1");
    digitalWrite(21, HIGH);
    // delay(200);
    // digitalWrite(6,LOW);
  }
  else{Serial.print("0");digitalWrite(21, LOW);}

}

#include <WiFi.h>

// Replace these with your WiFi network's SSID and password
const char *ssid = "lalalalala";
const char *password = "lalalala";

// Create a server object
WiFiServer server(6118);  // Use port 23 for the server

void setup() {
  Serial.begin(115200);
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
 
    while (client.connected()) {
 
      while (client.available()>0) {

        char c = client.read();
        
        Serial.write(c);
      }
 
      
    }
 
    client.stop();
    Serial.println("Client disconnected");
 
  }
}

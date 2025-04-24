#include <ArduinoJson.h>
#include <ArduinoJson.hpp>



bool readingJSON = false;
String lastJSON;
 const int capacity = JSON_OBJECT_SIZE(3) + 2 * JSON_OBJECT_SIZE(1);
StaticJsonDocument<capacity> doc;
void setup() {
  Serial.begin(9600);
}

void loop() {
  if (Serial.available()) {
    char c = Serial.read();
    //Serial.write(c);

    if (c == '{') {
      lastJSON = "";
      readingJSON = true;
    }

    if (readingJSON) {
      lastJSON += c;
    } else {
      if (c == 'a') {
        Serial.println(doc["type"].as<String>());
        Serial.println(doc["name"].as<String>());
      }
    }


    if (c == '}') {
      readingJSON = false;
      DeserializationError error = deserializeJson(doc, lastJSON);

      if (error) {
        Serial.print(F("[Arduino] Error: The JSON cannot be deserialized "));
        Serial.println(error.f_str());
        return;
      }
    }
  }
}
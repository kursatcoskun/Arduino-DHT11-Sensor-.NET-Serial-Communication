**ARDUINO VE DHT11 SENSORÜKULLANARAK C#İLE SERİ HABERLEŞME**

**Arduino IDE DHT11 Kodu**

```c
#include "DHT.h"

int pin=2;

DHT dht;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  dht.setup(2);

}

void loop() {
  // put your main code here, to run repeatedly:
  float nem= dht.getHumidity();
  float sicaklik=dht.getTemperature();
  Serial.print(nem,2);
  Serial.print(",");

  Serial.print(sicaklik,2);
  Serial.print(",");
  Serial.println();

  delay(1000);
}
```

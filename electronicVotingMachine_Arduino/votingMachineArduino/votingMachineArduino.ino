void setup()
{
  Serial.begin(9600);  //inicia comunicação serial com 9600
}
 
void loop()
{
  if(Serial.available())        //se algum dado disponível
  {
    char c = Serial.read();   //le o byte disponivel
    Serial.write(c);           //retorna o que foi lido
  }
}
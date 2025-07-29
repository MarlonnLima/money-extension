# Penny
Is a extension to convert decimal(money) to cents

## Methods
Penny adds an extension method for the decimal type to convert into cents it's called <code>ToCents</code>
```csharp
decimal valor = 279.98M;
var cents = valor.ToCents(); //27998 as integer
```

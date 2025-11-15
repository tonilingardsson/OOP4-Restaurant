# Restaurant System - Labb 4: Generic Collections

## Projektöversikt
Detta projekt demonstrerar användningen av generiska samlingar i C#:
- **List<T>** - för att hantera restaurangens meny
- **Queue<T>** - för att hantera beställningar (FIFO - first in, first out)

## Filstruktur

### MenuItem.cs
- Representerar en maträtt på menyn
- Innehåller: Id, Name, Price
- Använder **auto-implemented properties**
- Override av ToString() för snygg utskrift

### Order.cs
- Representerar en kundbeställning
- Innehåller: orderId (auto-incrementing), lista med MenuItem, bordsnummer
- Använder **private fields** med underscore-notation
- Static counter för att automatiskt generera unika order-ID:n
- Metod DisplayOrder() för att skriva ut beställningen

### Restaurant.cs
- Huvudklass som hanterar hela systemet
- **List<MenuItem> _menu** - samling av alla rätter
- **Queue<Order> _orderQueue** - kö för beställningar

#### Metoder:
1. **AddToMenu()** - Lägger till rätt i menyn (List.Add)
2. **ShowMenu()** - Visar alla rätter (foreach genom List)
3. **CreateOrder()** - Lägger till beställning (Queue.Enqueue)
4. **HandleOrder()** - Hanterar första beställningen (Queue.Dequeue)
5. **ShowOrders()** - Visar alla beställningar (foreach genom Queue)
6. **ShowNextOrder()** - Visar nästa beställning (Queue.Peek)
7. **ShowOrderCount()** - Visar antal beställningar (Queue.Count)

### Program.cs
- Kör hela simuleringen enligt uppgiftens krav
- Demonstrerar alla metoder i rätt ordning

## Viktiga Koncept

### List<T>
- Dynamisk array som kan växa/krympa
- Indexerad åtkomst: `list[0]`
- Metoder: Add(), Remove(), Count, Clear(), etc.
- Perfekt för menyn eftersom vi vill kunna läsa alla rätter

### Queue<T>
- FIFO (First In, First Out) - först in, först ut
- **Enqueue()** - lägg till sist i kön
- **Dequeue()** - ta bort och returnera första i kön
- **Peek()** - titta på första utan att ta bort
- **Count** - antal element i kön
- Perfekt för beställningar eftersom de ska hanteras i ordning!

## Körning
```bash
dotnet run
```

## Uppfyller kraven
✓ MenuItem-klass implementerad
✓ Order-klass implementerad med DisplayOrder()
✓ Restaurant-klass med List<MenuItem> och Queue<Order>
✓ Alla 7 metoder implementerade
✓ Simulering enligt specifikation (16 steg)
✓ Tydlig konsolutskrift med emojis och formatering
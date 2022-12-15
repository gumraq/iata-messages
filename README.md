# iata-messages
Сообщения обмена стандарта IATA

## Проекты репозитория
IataMessageProcessor - раскладка и сборка сообщений IATA

IataMessageStandard - структуры сообщений IATA

IataMessageSourceGenerator - генерация исходного кода структуры сообщений IATA

IataMessageTests - модульные тесты

## Цели и задачи, решаемые в репозитории
* Формирование и распознавание сообщений IATA
* Отправка и получение сообщений IATA
* Разработка точек интеграции для внешних систем

### Формирование и распознавание
Структурный объект данных - STANTARD

Обработка структурного объекта - PROCESSOR

#### Устройство структурного объекта данных STANTARD (Метаданные)
* Классы
* Свойства
  * Вложенные объекты (Structure_01_001_0006)
  * Строки (string)
  * Списки (List[Structire_004])
* Атрибуты 
  * Разделители (Slant, Crlf, Hyphen)
  * Нумератор (Reference)
#### Устройство обработчика структурного объекта PROCESSOR
* Formatter
  * Reflection
  * Generic
* Parser
  * Antlr4
  * dynamic expression

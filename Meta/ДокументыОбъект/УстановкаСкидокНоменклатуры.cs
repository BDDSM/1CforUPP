
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Упр)
	///</summary>
	public partial class УстановкаСкидокНоменклатуры:ДокументОбъект
	{
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.Валюты Валюта;
		public V82.Перечисления/*Ссылка*/.ВидыСкидок ВидСкидки;//Вид скидки
		public DateTime ДатаНачала;//Дата начала действия скидки
		public DateTime ДатаОкончания;//Дата окончания действия скидки
		public bool ДляВсейНоменклатуры;//Для всей номенклатуры
		public bool ДляВсехПолучателей;//Для всех получателей
		public object ЗначениеУсловия;//Значение условия
		public DateTime ОбщееВремяНачала;//Общее время начала
		public DateTime ОбщееВремяОкончания;//Общее время окончания
		public decimal/*(15.2)*/ ОграничениеСкидкиНаценки;//Ограничение скидки, наценки
		public decimal/*(5.2)*/ ПроцентСкидкиНаценки;//Процент скидки, наценки
		public V82.СправочникиСсылка.ТипыСкидокНаценок ТипСкидкиНаценки;//Тип скидки наценки
		public V82.Перечисления/*Ссылка*/.УсловияСкидкиНаценки Условие;
		public bool ПоДнямНедели;//По дням недели
		public V82.Перечисления/*Ссылка*/.ВидыОперацийУстановкаСкидокНоменклатуры ВидОперации;//Вид операции
		public V82.СправочникиСсылка.Качество Качество;
	}
}
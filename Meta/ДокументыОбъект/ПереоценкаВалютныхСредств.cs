
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	public partial class ПереоценкаВалютныхСредств:ДокументОбъект
	{
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		public V82.СправочникиСсылка.Организации Организация;
		public bool ВзаиморасчетыСКонтрагентами;//Взаиморасчеты с контрагентами
		public bool ВзаиморасчетыСПодотчетнымиЛицами;//Взаиморасчеты с подотчетными лицами
		public bool ДенежныеСредстваВКассах;//Денежные средства в кассах
		public bool ДенежныеСредстваНаБанковскихСчетах;//Денежные средства на банковских счетах
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///(Регл.учет)
		///</summary>
		public bool ПереоценкаВалютныхСредствРегл;//Переоценка валютных средств 
		///<summary>
		///(Регл.учет)
		///</summary>
		public bool ПереоценкаРасчетовВУсловныхЕдиницахРегл;//Переоценка расчетов в условных единицах
	}
}
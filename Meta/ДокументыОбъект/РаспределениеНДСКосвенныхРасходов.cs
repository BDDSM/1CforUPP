
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///Регламентная операция распеделения НДС косвенных расходов по видам реализации текущего периода
	///</summary>
	public partial class РаспределениеНДСКосвенныхРасходов:ДокументОбъект
	{
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///Сумма выручки, полученной в рамках деятельности облагаемой ЕНВД
		///</summary>
		public decimal/*(15.2)*/ ВыручкаЕНВД;//Выручка ЕНВД
		///<summary>
		///Сумма выручки, полученной в рамках деятельности не облагаемой НДС
		///</summary>
		public decimal/*(15.2)*/ ВыручкаБезНДС;//Выручка без НДС
		///<summary>
		///Сумма выручки, полученной в рамках деятельности облагаемой НДС по ставке 0%
		///</summary>
		public decimal/*(15.2)*/ ВыручкаНДС0;//Выручка НДС 0
		///<summary>
		///Сумма выручки, полученной в рамках деятельности облагаемой НДС по ставкам 18% и 10%
		///</summary>
		public decimal/*(15.2)*/ ВыручкаНДС;//Выручка НДС
		///<summary>
		///Начало налогового периода по НДС
		///</summary>
		public DateTime НачалоПериода;//Начало периода
		///<summary>
		///(Регл)
		///</summary>
		public object СчетСписанияНДС;//Счет списания НДС
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДС1;//Субконто 1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДС2;//Субконто 2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДС3;//Субконто 3
		///<summary>
		///(Регл)
		///</summary>
		public object СчетСписанияНДСНУ;//Счет списания НДС (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДСНУ1;//Субконто 1 (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДСНУ2;//Субконто 2 (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДСНУ3;//Субконто 3 (налоговый учет)
		public bool ДляСписанияНДСиспользоватьСчетИАналитикуУчетаЗатрат;//Для списания НДС использовать счет и аналитику учета затрат
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.НоменклатурныеГруппы НоменклатурнаяГруппа;//Номенклатурная группа
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.СтатьиЗатрат СтатьяЗатратСписанияНДС;//Статья затрат списания НДС
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
	}
}
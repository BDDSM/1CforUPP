
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class РегламентированныйОтчет:ДокументОбъект
	{
		///<summary>
		///(Общ) Имя встроенной или имя файла внешней обработки
		///</summary>
		public string/*(254)*/ ИсточникОтчета;//Источник отчета
		///<summary>
		///(Общ) Наименование регламентированного отчета
		///</summary>
		public string/*(100)*/ НаименованиеОтчета;//Наименование отчета
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДатаНачала;//Дата начала
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДатаОкончания;//Дата окончания
		///<summary>
		///(Общ) Дата подписи
		///</summary>
		public DateTime ДатаПодписи;//Дата подписи
		///<summary>
		///(Общ) Периодичность представления отчета
		///</summary>
		public V82.Перечисления/*Ссылка*/.Периодичность Периодичность;
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ПорядкиОкругленияОтчетности ЕдиницаИзмерения;//Единица измерения
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(1)*/ ТочностьЕдиницыИзмерения;//Точность единицы измерения
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ВыбраннаяФорма;//Выбранная форма
		///<summary>
		///(Общ) Сохраненные данные отчета
		///</summary>
		public ХранилищеЗначения ДанныеОтчета;//Данные отчета
		///<summary>
		///(Общ) Дерево со списком настроек страниц
		///</summary>
		public ХранилищеЗначения ДеревоНастройкиСтраниц;//Дерево настройки страниц
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыОтчетности ВидОтчетности;//Вид отчетности
		public string/*(0)*/ Комментарий;
		public string/*(4)*/ КодИМНС;//Код ИФНС
		public string/*(4)*/ КодИМНСПосредника;//Код ИФНС-посредника
		public string/*(30)*/ ФорматВыгрузки;//Формат выгрузки
		public decimal/*(3)*/ Вид;
		public string/*(16)*/ Период;
		public string/*(9)*/ КПП;
	}
}
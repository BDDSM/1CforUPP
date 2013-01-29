
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TarifyPochtovogoSbora")]
	[Route("/Catalogs/TarifyPochtovogoSbora/{Code}")]
	public class TarifyPochtovogoSboraRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<TarifyPochtovogoSboraRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TarifyPochtovogoSboraResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TarifyPochtovogoSboras")]
	[Route("/Catalogs/TarifyPochtovogoSboras/{Codes}")]
	public class TarifyPochtovogoSborasRequest/*��������������������������*/: IReturn<List<TarifyPochtovogoSboraRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TarifyPochtovogoSborasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TarifyPochtovogoSborasResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class TarifyPochtovogoSboraService /*��������������������������*/ : Service
	{
		public object Any(TarifyPochtovogoSboraRequest request)
		{
			return new TarifyPochtovogoSboraResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TarifyPochtovogoSboraRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new TarifyPochtovogoSboraResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(TarifyPochtovogoSborasRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}

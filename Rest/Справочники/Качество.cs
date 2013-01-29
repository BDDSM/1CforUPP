
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Kachestvo")]
	[Route("/Catalogs/Kachestvo/{Code}")]
	public class KachestvoRequest/*��������������*/: V82.�����������������.��������,IReturn<KachestvoRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KachestvoResponse//�������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Kachestvos")]
	[Route("/Catalogs/Kachestvos/{Codes}")]
	public class KachestvosRequest/*��������������*/: IReturn<List<KachestvoRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KachestvosRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KachestvosResponse//�������������
	{
		public string Result {get;set;}
	}


	public class KachestvoService /*��������������*/ : Service
	{
		public object Any(KachestvoRequest request)
		{
			return new KachestvoResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KachestvoRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������.�����������(���������);
				if (������ == null)
				{
					return new KachestvoResponse() {Result = "�������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������.�����������(1);
			}
		}

		public object Get(KachestvosRequest request)
		{
			var ��������� = new List<V82.�����������������.��������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������.�����������(���������);
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

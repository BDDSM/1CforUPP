
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ZvanieGrazhdanskogoVoinskogoUcheta")]
	[Route("/Catalogs/ZvanieGrazhdanskogoVoinskogoUcheta/{Code}")]
	public class ZvanieGrazhdanskogoVoinskogoUchetaRequest/*��������������������������������������*/: V82.�����������������.��������������������������������,IReturn<ZvanieGrazhdanskogoVoinskogoUchetaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ZvanieGrazhdanskogoVoinskogoUchetaResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ZvanieGrazhdanskogoVoinskogoUchetas")]
	[Route("/Catalogs/ZvanieGrazhdanskogoVoinskogoUchetas/{Codes}")]
	public class ZvanieGrazhdanskogoVoinskogoUchetasRequest/*��������������������������������������*/: IReturn<List<ZvanieGrazhdanskogoVoinskogoUchetaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ZvanieGrazhdanskogoVoinskogoUchetasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ZvanieGrazhdanskogoVoinskogoUchetasResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	public class ZvanieGrazhdanskogoVoinskogoUchetaService /*��������������������������������������*/ : Service
	{
		public object Any(ZvanieGrazhdanskogoVoinskogoUchetaRequest request)
		{
			return new ZvanieGrazhdanskogoVoinskogoUchetaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ZvanieGrazhdanskogoVoinskogoUchetaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������.�����������(���������);
				if (������ == null)
				{
					return new ZvanieGrazhdanskogoVoinskogoUchetaResponse() {Result = "�������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������.�����������(1);
			}
		}

		public object Get(ZvanieGrazhdanskogoVoinskogoUchetasRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������������.�����������(���������);
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

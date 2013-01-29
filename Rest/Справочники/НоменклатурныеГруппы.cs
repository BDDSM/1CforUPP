
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NomenklaturnyeGruppy")]
	[Route("/Catalogs/NomenklaturnyeGruppy/{Code}")]
	public class NomenklaturnyeGruppyRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<NomenklaturnyeGruppyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NomenklaturnyeGruppyResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NomenklaturnyeGruppys")]
	[Route("/Catalogs/NomenklaturnyeGruppys/{Codes}")]
	public class NomenklaturnyeGruppysRequest/*��������������������������*/: IReturn<List<NomenklaturnyeGruppyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NomenklaturnyeGruppysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NomenklaturnyeGruppysResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class NomenklaturnyeGruppyService /*��������������������������*/ : Service
	{
		public object Any(NomenklaturnyeGruppyRequest request)
		{
			return new NomenklaturnyeGruppyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NomenklaturnyeGruppyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new NomenklaturnyeGruppyResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(NomenklaturnyeGruppysRequest request)
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


using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiRaschetaCenyNomenklatury")]
	[Route("/Catalogs/NastrojjkiRaschetaCenyNomenklatury/{Code}")]
	public class NastrojjkiRaschetaCenyNomenklaturyRequest/*��������������������������������������*/: V82.�����������������.��������������������������������,IReturn<NastrojjkiRaschetaCenyNomenklaturyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiRaschetaCenyNomenklaturyResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiRaschetaCenyNomenklaturys")]
	[Route("/Catalogs/NastrojjkiRaschetaCenyNomenklaturys/{Codes}")]
	public class NastrojjkiRaschetaCenyNomenklaturysRequest/*��������������������������������������*/: IReturn<List<NastrojjkiRaschetaCenyNomenklaturyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiRaschetaCenyNomenklaturysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiRaschetaCenyNomenklaturysResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiRaschetaCenyNomenklaturyService /*��������������������������������������*/ : Service
	{
		public object Any(NastrojjkiRaschetaCenyNomenklaturyRequest request)
		{
			return new NastrojjkiRaschetaCenyNomenklaturyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiRaschetaCenyNomenklaturyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiRaschetaCenyNomenklaturyResponse() {Result = "�������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiRaschetaCenyNomenklaturysRequest request)
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

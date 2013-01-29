
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SHablonyFormulRascheta")]
	[Route("/Catalogs/SHablonyFormulRascheta/{Code}")]
	public class SHablonyFormulRaschetaRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<SHablonyFormulRaschetaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SHablonyFormulRaschetaResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SHablonyFormulRaschetas")]
	[Route("/Catalogs/SHablonyFormulRaschetas/{Codes}")]
	public class SHablonyFormulRaschetasRequest/*��������������������������*/: IReturn<List<SHablonyFormulRaschetaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SHablonyFormulRaschetasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SHablonyFormulRaschetasResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class SHablonyFormulRaschetaService /*��������������������������*/ : Service
	{
		public object Any(SHablonyFormulRaschetaRequest request)
		{
			return new SHablonyFormulRaschetaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SHablonyFormulRaschetaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new SHablonyFormulRaschetaResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(SHablonyFormulRaschetasRequest request)
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

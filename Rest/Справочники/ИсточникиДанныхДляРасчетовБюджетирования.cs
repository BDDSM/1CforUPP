
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/IstochnikiDannykhDlyaRaschetovByudzhetirovaniya")]
	[Route("/Catalogs/IstochnikiDannykhDlyaRaschetovByudzhetirovaniya/{Code}")]
	public class IstochnikiDannykhDlyaRaschetovByudzhetirovaniyaRequest/*����������������������������������������������*/: V82.�����������������.����������������������������������������,IReturn<IstochnikiDannykhDlyaRaschetovByudzhetirovaniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class IstochnikiDannykhDlyaRaschetovByudzhetirovaniyaResponse//���������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/IstochnikiDannykhDlyaRaschetovByudzhetirovaniyas")]
	[Route("/Catalogs/IstochnikiDannykhDlyaRaschetovByudzhetirovaniyas/{Codes}")]
	public class IstochnikiDannykhDlyaRaschetovByudzhetirovaniyasRequest/*����������������������������������������������*/: IReturn<List<IstochnikiDannykhDlyaRaschetovByudzhetirovaniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public IstochnikiDannykhDlyaRaschetovByudzhetirovaniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class IstochnikiDannykhDlyaRaschetovByudzhetirovaniyasResponse//���������������������������������������������
	{
		public string Result {get;set;}
	}


	public class IstochnikiDannykhDlyaRaschetovByudzhetirovaniyaService /*����������������������������������������������*/ : Service
	{
		public object Any(IstochnikiDannykhDlyaRaschetovByudzhetirovaniyaRequest request)
		{
			return new IstochnikiDannykhDlyaRaschetovByudzhetirovaniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(IstochnikiDannykhDlyaRaschetovByudzhetirovaniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new IstochnikiDannykhDlyaRaschetovByudzhetirovaniyaResponse() {Result = "���������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������������������������.�����������(1);
			}
		}

		public object Get(IstochnikiDannykhDlyaRaschetovByudzhetirovaniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������������������������.�����������(���������);
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
